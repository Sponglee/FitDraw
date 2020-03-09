using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour, IInteractable
{
  
    [SerializeField] private Rigidbody enemyRb;

    [SerializeField] private float speed = 0.1f;
    [SerializeField] private bool Movable = false;
    [SerializeField] private bool wasHit = false;
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

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Movable && !WasHit)
            transform.Translate(Vector3.forward * speed);
    }


    private void Start()
    {


        enemyRb= GetComponent<Rigidbody>();
    }


    public void GotHit(Transform triggerTransform)
    {
        

        WasHit = true;
        enemyRb.constraints = RigidbodyConstraints.None;
        enemyRb.AddForce(Vector3.up * 270f);
        if (transform.position.x - triggerTransform.position.x > 0)
        {
            enemyRb.AddTorque(-Vector3.right * 700f);
            enemyRb.AddForce(Vector3.right * 270f);
            //Debug.Log("LEFT");
        }
        else
        {
            enemyRb.AddTorque(Vector3.right * 700f);
            enemyRb.AddForce(-Vector3.right * 270f);
            //Debug.Log("RIGHT");
        }
        //Debug
        transform.GetComponent<Renderer>().material.color = Color.grey;
    }

    public void PushBack()
    {
        enemyRb.AddForce(Vector3.forward * 270f);
    }

    public void CollisionInteract(Transform collisionTransform)
    {
        PushBack();
    }

    public void TriggerInteract(Transform triggerTransform)
    {
        GotHit(triggerTransform);
    }
}
