using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySwinger : MonoBehaviour
{
    [SerializeField] private Transform weaponRef;

    [SerializeField] private float shootRate = 1f;
    [SerializeField] private Animator anim;

    private void Start()
    {
        InvokeRepeating(nameof(Swing), 2f, shootRate);
    }


    private void Swing()
    {
        anim.SetTrigger("EnemySwing");

    }

    

    //private void OnCollisionEnter(Collision collision)
    //{

    //    if (collision.transform.CompareTag("Shield") || (collision.transform.CompareTag("Enemy") && collision.transform.GetComponent<EnemyMover>().WasHit))
    //    {
    //        rb.AddForce(Vector3.forward * 270f);
    //    }
    //    else if (collision.transform.CompareTag("Water"))
    //    {
    //        Destroy(gameObject, 1f);
    //    }
    //    //else if (collision.transform.CompareTag("Player"))
    //    //{
    //    //    GotHit(collision.transform);
    //    //}
    //}
}
