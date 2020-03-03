using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawInput : MonoBehaviour
{
    public GameObject brushPref;
    public Transform reference;

    private GameObject trail;
    private Vector3 startPos;
    private Plane objectPlane;

    private void Start()
    {
        objectPlane = new Plane(Camera.main.transform.forward * -1, reference.position);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
