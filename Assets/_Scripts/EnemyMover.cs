using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;
    private Rigidbody rb;

    [SerializeField] private bool Movable = false;

    private bool wasHit = false;
    public bool WasHit
    {
        get
        {
            return wasHit;
        }

        set
        {
            wasHit = value;
            Invoke(nameof(ResetHit), 1f);
        }
    }

    private void ResetHit()
    {
        wasHit = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Movable && !WasHit)
            transform.Translate(Vector3.forward * speed);
    }


    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.transform.CompareTag("Shield") || (collision.transform.CompareTag("Enemy") && collision.transform.GetComponent<EnemyMover>().WasHit))
        {
            rb.AddForce(Vector3.forward * 270f);
        }
        else if (collision.transform.CompareTag("Water"))
        {
            Destroy(gameObject, 1f);
        }
        //else if (collision.transform.CompareTag("Player"))
        //{
        //    GotHit(collision.transform);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            GotHit(other.transform);
        }
    }

    public void GotHit(Transform collisionTransform)
    {
        WasHit = true;
        rb.constraints = RigidbodyConstraints.None;
        rb.AddForce(Vector3.up * 270f);
        if(transform.position.x - collisionTransform.position.x>0)
        {
            rb.AddTorque(-Vector3.right * 700f);
            rb.AddForce(Vector3.right* 270f);
            //Debug.Log("LEFT");
        }
        else
        {
            rb.AddTorque(Vector3.right * 700f);
            rb.AddForce(-Vector3.right * 270f);
            //Debug.Log("RIGHT");
        }
        transform.GetComponent<Renderer>().material.color = Color.grey;
    }
}
