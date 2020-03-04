using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject[] enemyPrefs;

    // Start is called before the first frame update
    void Start()
    {
            InvokeRepeating(nameof(SpawnEnemyWave),2f,5f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
        }
    }


    public void SpawnEnemyWave()
    {
        for (int i = 0; i < Random.Range(5,20); i++)
        {
            Instantiate(enemyPrefs[Random.Range(0,enemyPrefs.Length)], transform.position + Vector3.right*(Random.Range(-2f,1f)),Quaternion.AngleAxis(180f,Vector3.up),transform);
        }
    }

}
