using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZURMissile : MonoBehaviour
{
    [SerializeField]
    DisplayInfo disp;
    [SerializeField]
    ZUR zur;
    [SerializeField]
    RLS radar;
    [SerializeField]
    GameObject srapnel;
    GameObject shapes;
    [SerializeField]
    GameObject uiPoint;
    public GameObject agm;

    Vector3 meteengPoint;
    public Vector3 direction;
    bool isSafe = false;
    bool isApproaching = true;
    float safeTime = 1.5f;
    float timer = 0f;
    float undockingSpeed = 8.37f;
    float distance;
    float[] speed = new float[15] {250,250,250,400,600,700,650,600,550,500,450,300,250,250,200};

    private void Start()
    {
        meteengPoint = new Vector3(0,0,0);
        disp.SetState("ЗУР летит в упрежденную точку");
        
    }

    void FixedUpdate()
    {
        disp.SetCoordinates(GetSpeed(),distance,agm.transform.position.z);
        distance = Tools.VectorLength(agm.transform.position - transform.position);
        direction = meteengPoint.normalized;
        if(distance <= 9f)
        {
            Explode();
        }
        if (isSafe && isApproaching)
        {
            Chase();
        }
        else
        {
            MoveAway();
        }
    }

    void MoveAway()
    {
        safeTime -= Time.deltaTime;
        if (safeTime < 0) isSafe = true;
        transform.position += new Vector3(Mathf.Cos(transform.eulerAngles.y * Mathf.Deg2Rad),0,  -Mathf.Sin(transform.eulerAngles.y * Mathf.Deg2Rad)) * undockingSpeed * Time.deltaTime;
    }

    void Chase()
    {
        timer += Time.deltaTime;
        float xA, yA, zA,dx,dy,dz;
        dx = agm.transform.position.x- transform.position.x;
        dy = agm.transform.position.y- transform.position.y;
        dz = agm.transform.position.z + GetPreemption() - transform.position.z;
        xA = Mathf.Asin(dx / distance);
        yA = Mathf.Asin(dy / distance);
        zA = -Mathf.Acos(dz / distance);
        if (zA != zA)
        {
            zA = 0;
        }
        else
        {
            zA = -Mathf.Acos(dz / distance); 
        }
        meteengPoint = new Vector3(Mathf.Sin(xA), Mathf.Sin(yA), Mathf.Cos(zA));
        try
        {
            transform.position += direction * GetSpeed() * Time.deltaTime;
        }
        catch
        {
            transform.position += Vector3.forward * GetSpeed() * Time.deltaTime;
        }
        Quaternion rotation = Quaternion.LookRotation(-direction, Vector3.up);
        transform.rotation = rotation;

    }

    float GetSpeed()
    {
        if (timer / 2 < 14) return speed[(int)(timer / 2)];
        else return speed[14];
    }
    
    float GetPreemption()
    {
        float a;
        if (distance > 1000) a = 500;
        else if (distance > 100) a = 50;
        else a = 10;
        return 250 * a / 450;
    }
    void Explode()
    {
        shapes = Instantiate(srapnel, transform.position, Quaternion.LookRotation(-direction,Vector3.up));
        shapes.SetActive(true);
        Destroy(gameObject);
    }
}
