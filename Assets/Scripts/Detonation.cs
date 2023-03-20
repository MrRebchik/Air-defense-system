using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonation : MonoBehaviour
{
    [SerializeField]
    ZURMissile miss;
    [SerializeField]
    GameObject shape;
    float angle = 0.9f;
    GameObject[] shapes = new GameObject[400];

    void Start()
    {
        for(int i = 0; i < 400; i++)
        {
            shapes[i] = Instantiate(shape,transform.position,Quaternion.AngleAxis(angle*i,miss.direction),gameObject.transform);
            shapes[i].SetActive(true);
            angle += 0.9f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += miss.direction * 450f * Time.deltaTime;
    }
}
