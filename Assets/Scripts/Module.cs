using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class Module : MonoBehaviour
{
    GameObject disp;
    GameObject prev1;
    public DisplayInfo d;
    public float sharps = 0;
    public bool isCapable = true;
    public Material alive;
    public Material ded;
    public Image a;
    private void Start()
    {
        prev1 = GameObject.Find("CM FreeLook1");
        disp = GameObject.Find("Canvas");
        a.material = alive;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sharp")
        {
            sharps++;
            Time.timeScale = 0.01f;
        }
        if(Random.Range(0,1)<(1- Mathf.Pow(2.7f, -sharps)))
        {
            isCapable = false;
            a.material = ded;
            disp.GetComponent<DisplayInfo>().SetMisState("Один из модулей выведен из строя");
        }

    }
}
