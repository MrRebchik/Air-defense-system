using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class DisplayInfo : MonoBehaviour
{
    public Text coordinates;
    public Text AGMState;
    public Text systemState;
    public GameObject camBPLA;
    public GameObject camZUR;
    public GameObject camVerh;
    public GameObject camLeft;
    public GameObject camAGM;

    public void SetMisState(string a)
    {
        AGMState.text = a;
    }
    public void SetState(string a)
    {
        systemState.text = a;
    }
    public void SetCoordinates(float a, float b,float c)
    {
        coordinates.text = "Скорость ЗУР:"+ a.ToString() + "\n" + "Расстояние до цели:" + b.ToString() + "\n" + "дистанция по х:" + c.ToString();
    }

    public void SetLeftCam()
    {
        camBPLA.SetActive(false);
        camZUR.SetActive(false);
        camVerh.SetActive(false);
        camLeft.SetActive(true);
        camAGM.SetActive(false);
    }
    public void SetVerhCam()
    {
        camBPLA.SetActive(false);
        camZUR.SetActive(false);
        camVerh.SetActive(true);
        camLeft.SetActive(false);
        camAGM.SetActive(false);
    }
    public void SetZURCam()
    {
        camBPLA.SetActive(false);
        camZUR.SetActive(true);
        camVerh.SetActive(false);
        camLeft.SetActive(false);
        camAGM.SetActive(false);
    }
    public void SetBPLACam()
    {
        camBPLA.SetActive(true);
        camZUR.SetActive(false);
        camVerh.SetActive(false);
        camLeft.SetActive(false);
        camAGM.SetActive(false);
    }
    public void SetAGMCam()
    {
        camBPLA.SetActive(false);
        camZUR.SetActive(false);
        camVerh.SetActive(false);
        camLeft.SetActive(false);
        camAGM.SetActive(true);
    }
}
