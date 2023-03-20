using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPLA : MonoBehaviour
{
    [SerializeField]
    DisplayInfo disp;
    float patrolRadius = 320f;
    public float degreesPerSecond = 1.5f;
    public float deltaTime = 0;

    private void Start()
    {
        disp.SetState("БПЛА барражирует в режиме поиска цели");
    }
    public void Navigation()
    {
        transform.position = new Vector3(patrolRadius * Mathf.Cos(deltaTime * Mathf.PI / 180),400, patrolRadius * Mathf.Sin(deltaTime * Mathf.PI / 180));
    }

    public void GetDirection()
    {
        transform.rotation = Quaternion.AngleAxis((90-degreesPerSecond*deltaTime/60)%360, Vector3.up);
    }


    public void FixedUpdate()
    {
        deltaTime += Time.deltaTime * degreesPerSecond;
        GetDirection();
        Navigation();
    }
}
