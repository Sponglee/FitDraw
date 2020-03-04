using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{

    [SerializeField] private GameObject projectilePref;

    [SerializeField]private float shootRate = 1f;

    private void Start()
    {
        InvokeRepeating(nameof(Shoot),2f,shootRate);
    }


    private void Shoot()
    {
        Instantiate(projectilePref, transform.position, transform.rotation);
    }

}

