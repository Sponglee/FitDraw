﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    public Camera drawCamera;

    public GameObject linePrefab;
    public GameObject currentLine;

    public LineRenderer lineRenderer;

    public List<Vector2> fingerPositions;

    public Transform resultHolder;

    public float pointStep = 0.1f;
    
   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

            resultHolder.GetComponent<FormLine>().ResetBalls();

            if(currentLine!= null)
                Destroy(currentLine);
            CreateLine();
        }
        else if(Input.GetMouseButton(0))
        {
            Vector2 tempFingerPosition = drawCamera.ScreenToWorldPoint(Input.mousePosition);
            if(Vector2.Distance(tempFingerPosition,fingerPositions[fingerPositions.Count-1])>pointStep)
            {
                UpdateLine(tempFingerPosition);
            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            resultHolder.GetComponent<FormLine>().linePoints = fingerPositions;
            resultHolder.GetComponent<FormLine>().FormBallLine();
        }
    }

    private void CreateLine()
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        fingerPositions.Clear();

        fingerPositions.Add(drawCamera.ScreenToWorldPoint(Input.mousePosition));
       
        lineRenderer.SetPosition(0, fingerPositions[0]);
        //lineRenderer.SetPosition(1, fingerPositions[1]);

    }


    private void UpdateLine(Vector2 newFingerPosition)
    {
        fingerPositions.Add(newFingerPosition);
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newFingerPosition);
    }
}
