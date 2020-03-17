using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoHandedController : WeaponController
{


    public override void WeaponNotActive()
    {
        mainHand.transform.eulerAngles = new Vector3(-25f, -60f, 0);
        offHand.transform.eulerAngles = new Vector3(-5f, 0f, 0f);
        offHand.GetChild(0).GetComponent<BoxCollider>().enabled = true;
        mainHand.GetChild(0).GetComponent<BoxCollider>().enabled = false;
        //transform.GetComponent<CapsuleCollider>().enabled = false;
    }

    public override void WeaponActive()
    {
        mainHand.transform.eulerAngles = Vector3.zero;
        offHand.transform.eulerAngles = new Vector3(0, -90f, 0);
        offHand.GetChild(0).GetComponent<BoxCollider>().enabled = false;
        mainHand.GetChild(0).GetComponent<BoxCollider>().enabled = true;
        //transform.GetComponent<CapsuleCollider>().enabled = true;
    }



}
