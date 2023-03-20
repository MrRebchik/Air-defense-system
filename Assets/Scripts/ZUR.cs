using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZUR : MonoBehaviour
{
    float maxDeviation = 10f;
    public Vector3 curentPosition;
    float bplaDirection;
    float agmDirection;
    [SerializeField]
    GameObject missile;
    [SerializeField]
    RLS radar;
    [SerializeField]
    BPLA basement;
    bool isLoaded = true;


    private void FixedUpdate()
    {
        bplaDirection = Mathf.Abs((270 - basement.degreesPerSecond * basement.deltaTime / 60) % 360);
        agmDirection = Tools.GetAngleY(transform.position, curentPosition);
        // Debug.Log(Mathf.Abs(bplaDirection - 90 - agmDirection)); // -- разность направлений между бпла и кр
        curentPosition = radar.secondTargetPosition + (radar.secondTargetPosition - radar.firstTargetPosition) * 0.881f * (radar.timer - radar.secondDetectionTime);
        if (isLoaded && radar.isTakenOnTracking && Mathf.Abs(bplaDirection - 90 - agmDirection) < maxDeviation)
        {
            Fire();
        }
    }

    void Fire()
    {
        isLoaded = false;
        missile.transform.position = gameObject.transform.position;
        missile.transform.rotation = gameObject.transform.rotation;
        missile.SetActive(true);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
