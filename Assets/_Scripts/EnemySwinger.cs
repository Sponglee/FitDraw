using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySwinger : MonoBehaviour
{
   
    [SerializeField] private EnemyController enemyController;
  
    [SerializeField] private float shootRate = 1f;
    [SerializeField] private Animator anim;

    private void Start()
    {
        enemyController = transform.parent.GetComponent<EnemyController>();
        InvokeRepeating(nameof(Swing), 2f, shootRate);

        enemyController.OnPushBack.AddListener(SwingInterrupted);
    }


    private void Swing()
    {
        anim.Play("EnemySwing");

    }

    
    private void SwingInterrupted()
    {
        //Debug.Log("Swing");
        anim.SetTrigger("SwingInterrupted");
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
