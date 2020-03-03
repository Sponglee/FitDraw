using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    public GameObject pref;

    [SerializeField]private Vector3[] points;
    public Vector3[] Points
    {
        get
        {
            return points;
        }

        set
        {
            points = value;
            for (int i = 0; i < points.Length; i++)
            {
                GameObject tmpBall = Instantiate(pref, points[i], Quaternion.identity,transform);
               
            }
        }
    }

   
}
