using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailDrawer : MonoBehaviour
{
    public RectTransform mouseReference;
    public Canvas canvasReference;
    public Mesh outMesh;
    public Transform resultHolder;
    public Camera drawingCam;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        outMesh = new Mesh();
    }
    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButtonDown(0))
        {
            mouseReference.position = CalculatePositionFromMouseToRectTransform(canvasReference, Camera.main);
            mouseReference.GetComponent<TrailRenderer>().enabled = true;
        }
        else if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0))
        {

            mouseReference.position = CalculatePositionFromMouseToRectTransform(canvasReference, Camera.main);

        }
        else if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
        {
            mouseReference.GetComponent<TrailRenderer>().BakeMesh(outMesh, drawingCam);

            resultHolder.GetComponent<MeshFilter>().sharedMesh = outMesh;
            mouseReference.GetComponent<TrailRenderer>().Clear();
            mouseReference.GetComponent<TrailRenderer>().enabled = false;

        }
    }

    private Vector3 CalculatePositionFromMouseToRectTransform(Canvas _Canvas, Camera _Cam)
    {
        Vector3 Return = Vector3.zero;

        if (_Canvas.renderMode == RenderMode.ScreenSpaceOverlay)
        {
            Return = Input.mousePosition;
        }
        else if (_Canvas.renderMode == RenderMode.ScreenSpaceCamera)
        {
            Vector2 tempVector = Vector2.zero;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_Canvas.transform as RectTransform, Input.mousePosition, _Cam, out tempVector);
            Return = _Canvas.transform.TransformPoint(tempVector);
        }

        return Return;
    }

}