using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AGM : MonoBehaviour
{
    [SerializeField]
    DisplayInfo disp;
    readonly float AGMSpeed = 250f; //775-1000 (900)km\h
    bool isDestructed = false;
    private void Start()
    {
        disp.SetMisState("Крылатая ракета летит");
        //Time.timeScale = 3f ;
    }
    public void Navigation()
    {
        if (!isDestructed)
        {
            transform.position += new Vector3(0, 0, AGMSpeed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    { 
        Navigation();
    }
}
