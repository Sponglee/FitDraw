using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;
    private Rigidbody rb;

    private bool WasHit = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!WasHit)
            transform.Translate(transform.forward  * speed);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            WasHit = true;
            rb.constraints = RigidbodyConstraints.None;
            rb.AddForce(Vector3.right * Random.Range(-2f,1f)*15f+ Vector3.up * 700f);
        }
        else if(collision.transform.CompareTag("Water"))
        {
            Destroy(gameObject, 1f);
        }
    }

}
