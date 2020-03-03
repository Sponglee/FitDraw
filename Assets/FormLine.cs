using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormLine : MonoBehaviour
{
    public List<Vector2> linePoints;
    public GameObject ballPref;



    public void FormBallLine()
    {
        if(linePoints.Count>1)
        {
            for (int i = 0; i < linePoints.Count; i++)
            {
                Instantiate(ballPref, new Vector3(linePoints[i].x,linePoints[i].y,0) , Quaternion.identity, transform);
            }

            transform.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    
    public void ResetBalls()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }

        transform.GetComponent<Rigidbody>().isKinematic = true;
        transform.position = Vector3.zero;
    }
}
