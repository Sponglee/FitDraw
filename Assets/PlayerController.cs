using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform shield;
    public Transform weapon;

   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            weapon.transform.eulerAngles = Vector3.zero;
            shield.transform.eulerAngles = new Vector3(0,-90f,0);
            shield.GetComponent<BoxCollider>().enabled = false;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            weapon.transform.eulerAngles = new Vector3(25f,60f,0);
            shield.transform.eulerAngles = Vector3.zero;
            shield.GetComponent<BoxCollider>().enabled = true;
        }
    }

    public void RotateEquipment(Transform target)
    {

    }

}
