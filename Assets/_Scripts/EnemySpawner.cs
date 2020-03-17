using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform spawnPoints;
  

    public GameObject[] enemyPrefs;

    // Start is called before the first frame update
    void Start()
    {
            InvokeRepeating(nameof(SpawnEnemyWave),2f,5f);

    }

    

    public void SpawnEnemyWave()
    {
        //Select a spawn point

        for (int i = 0; i < Random.Range(5,20); i++)
        {
            Transform tmpTransform = spawnPoints.GetChild(Random.Range(0, spawnPoints.childCount));
            Instantiate(enemyPrefs[Random.Range(0,enemyPrefs.Length)], tmpTransform.position + Vector3.right*(Random.Range(0f,1f)),Quaternion.AngleAxis(180f,Vector3.up),transform);
        }
    }

}
