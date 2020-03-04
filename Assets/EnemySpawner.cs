using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPref;

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
        for (int i = 0; i < Random.Range(1,10); i++)
        {
            Instantiate(enemyPref, transform.position + Vector3.right*(Random.Range(-2f,1f)),Quaternion.AngleAxis(180f,Vector3.up),transform);
        }
    }

}
