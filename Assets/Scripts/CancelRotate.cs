using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelRotate : MonoBehaviour
{
    float deltaTime = 0;
    void Update()
    {
        deltaTime += Time.deltaTime * 1.5f;
        transform.rotation = Quaternion.AngleAxis(-(90 - 1.5f * deltaTime / 60) % 360, Vector3.up);
    }
}
