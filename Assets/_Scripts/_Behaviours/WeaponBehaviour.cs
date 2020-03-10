using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBehaviour: MonoBehaviour, IInteractable
{
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent<IInteractable>() != null)
        {
            other.transform.GetComponent<IInteractable>().TriggerInteract(transform);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("CLING: " + collision.gameObject.name);
        if (collision.transform.GetComponent<IInteractable>() != null)
        {
            collision.transform.GetComponent<IInteractable>().CollisionInteract(transform);
        }
    }

    public virtual void CollisionInteract(Transform collisionTransform){}
    public virtual void TriggerInteract(Transform triggerTransform){}

}
