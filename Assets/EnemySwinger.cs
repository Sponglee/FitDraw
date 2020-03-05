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


  
}
