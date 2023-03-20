using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLS : MonoBehaviour
{
    [SerializeField]
    DisplayInfo disp;
    readonly float detectionDistance = 17000f;
    bool isDetected = false;
    bool isFirstLightUp = true;
    public bool isTakenOnTracking = false;
    public float timer = 0f;
    public Vector3 firstTargetPosition;
    public Vector3 secondTargetPosition;
    public float firstDetectionTime;
    public float secondDetectionTime;
    public float targetSpeed;

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        
    }
    void OnTriggerEnter(Collider other)
    {
        isDetected = Detection(gameObject.transform.position, other.transform.position);
        if (isDetected)
        {
            if (other.tag == "AGM")
            {
                
                if (isFirstLightUp)
                {
                    isFirstLightUp = false;
                    firstTargetPosition = other.transform.position;
                    firstDetectionTime = timer;
                }
                else if (!isTakenOnTracking)
                {
                    disp.SetState("РЛС взял КР на сопровождение");
                    secondDetectionTime = timer;
                    secondTargetPosition = other.transform.position;
                    targetSpeed = Tools.VectorLength(secondTargetPosition - firstTargetPosition) / (secondDetectionTime - firstDetectionTime);
                    isTakenOnTracking = true;
                }

            }
        }
    }
    bool Detection(Vector3 bpla,Vector3 agm)
    {
        return detectionDistance > Tools.VectorLength(bpla - agm);
    }
}
