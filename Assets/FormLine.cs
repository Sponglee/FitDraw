using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormLine : MonoBehaviour
{
    public List<Vector2> linePoints;
    public GameObject ballPref;



    public void FormBallLine()
    {
        for (int i = 0; i < linePoints.Count; i++)
        {
            Instantiate(ballPref, new Vector3(linePoints[i].x,linePoints[i].y,0) , Quaternion.identity, transform);
        }
    }

    
}
