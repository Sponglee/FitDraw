using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.GetComponent<IInteractable>() != null)
        {
            collision.transform.GetComponent<IInteractable>().CollisionInteract(transform);
        }
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.GetComponent<IInteractable>() != null)
        {
            other.transform.GetComponent<IInteractable>().TriggerInteract(transform);
        }
    }
}
