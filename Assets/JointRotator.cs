using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointRotator : MonoBehaviour
{

    [SerializeField]private float speed = 1f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
    }
}
