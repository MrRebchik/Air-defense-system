using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tracker : MonoBehaviour
{
    public GameObject agm;
    public GameObject zur;
    public GameObject red;
    public GameObject green;
    public DisplayInfo d;
    public Transform parent;
    public Text kurs;
    public GameObject rocket;
    private void Update()
    {
        
        try
        {
            Instantiate(red, agm.transform.position, Quaternion.identity,parent);
            Instantiate(green, zur.transform.position, Quaternion.identity,parent);
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                d.SetBPLACam();
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                d.SetZURCam();
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                d.SetAGMCam();
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                d.SetVerhCam();
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                d.SetLeftCam();
            }
        }
        catch
        {
            d.camVerh.SetActive(true);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sharp")
        {
            d.SetLeftCam();
            //Camera.main.cullingMask = 4;
        }

    }

    public void Launch()
    {
        agm.SetActive(true);
        rocket.transform.position = new Vector3( float.Parse(kurs.text),1950,-20000);
    }
}
