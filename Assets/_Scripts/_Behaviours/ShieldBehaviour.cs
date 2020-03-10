using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.GetComponent<IInteractable>() != null)
        {
            Debug.Log("SHIELD: " + collision.gameObject.name);
            collision.transform.GetComponent<IInteractable>().CollisionInteract(transform);
        }
    }


}
