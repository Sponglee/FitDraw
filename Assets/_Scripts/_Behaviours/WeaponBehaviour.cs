using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour: MonoBehaviour
{
    public void CollisionInteract(Transform collisionTransform)
    {

        if (collisionTransform.CompareTag("Enemy") && collisionTransform.GetComponent<EnemyController>().WasHit)
        {
            
        }
        else if (collisionTransform.CompareTag("Shield"))
        {
            //Interact with enemy shield
        }


    }

    public void TriggerInteract(Transform triggerTransform)
    {
        triggerTransform.GetComponent<EnemyController>().GotHit(transform);
      
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.GetComponent<IInteractable>() != null)
        {
            other.transform.GetComponent<IInteractable>().TriggerInteract(transform);
        }
    }

}
