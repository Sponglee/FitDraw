using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IInteractable
{
    public static Transform playerTransform;

  
    public Rigidbody rb;

    [SerializeField] private float speed=130f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        playerTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButton(0))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 1f / 10f * speed);
            
        }
        else if(Input.GetMouseButtonUp(0))
        {
           
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0f);
        }
    }

  

    


    public void CollisionInteract(Transform collisionTransform)
    {
        Debug.Log("HIT");
        //FunctionHandler.Instance.GameOver();
    }

    public void TriggerInteract(Transform triggerTransform)
    {
       
    }
}
