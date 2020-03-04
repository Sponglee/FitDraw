using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{

    [SerializeField] private float speed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Shield"))
        {
            Destroy(gameObject);
        }
    }
}
