using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public Transform offHand;
    public Transform mainHand;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            WeaponActive();

        }
        else if (Input.GetMouseButtonUp(0))
        {
            WeaponNotActive();
        }

    }


    public virtual void WeaponNotActive()
    {
    }

    public virtual void WeaponActive()
    {
    }


}
