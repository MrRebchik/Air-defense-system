using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSwich : MonoBehaviour
{
    public DisplayInfo d;
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    d.SetBPLACam();
        //    Debug.Log(1);
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    d.SetZURCam();
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha5))
        //{
        //    d.SetLeftCam();
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha4))
        //{
        //    d.SetVerhCam();
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    d.SetAGMCam();
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sharp")
        {
            d.SetLeftCam();
            //Camera.main.cullingMask = 4;
        }

    }
}
