using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotationController : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 1f;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private PlayerController playerController;

    [SerializeField] private Vector2 inputRange = new Vector2(1, 1);
    [SerializeField] private Transform target;

    private void Start()
    {
        inputManager = InputManager.Instance;
        
    }
    void Update()
    {
        RotateWeapon();
    }


    public void RotateWeapon()
    {

        Vector3 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(-relativePos,target.forward);
        transform.rotation = Quaternion.Lerp(transform.rotation,
                                                 rotation, Time.deltaTime * rotationSpeed);

        
        //    //Rotate player towards movement

        //    Vector3 lookDirection = new Vector3(inputManager.input.x * inputRange.x, inputManager.input.y * inputRange.y / 2f, 1f);
        //    Quaternion lookRotation = Quaternion.LookRotation(lookDirection, Vector3.up);
        //    float step = rotationSpeed * Time.deltaTime;
        //    transform.rotation = Quaternion.RotateTowards(lookRotation, transform.rotation, step);

    }
}
