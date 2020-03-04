using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform shield;
    public Transform weapon;

    public Rigidbody rb;

    [SerializeField] private float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            weapon.transform.eulerAngles = Vector3.zero;
            shield.transform.eulerAngles = new Vector3(0,-90f,0);
            shield.GetComponent<BoxCollider>().enabled = false;
           
        }
        else if(Input.GetMouseButton(0))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 1f / 10f * speed);
        }
        else if(Input.GetMouseButtonUp(0))
        {
            weapon.transform.eulerAngles = new Vector3(25f,60f,0);
            shield.transform.eulerAngles = Vector3.zero;
            shield.GetComponent<BoxCollider>().enabled = true;
           
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0f);
        }
    }

    public void RotateEquipment(Transform target)
    {

    }

}
