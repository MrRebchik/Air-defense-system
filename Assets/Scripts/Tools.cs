using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Tools
{
    public static float VectorLength(Vector3 a)
    {
        return Mathf.Sqrt(a.x*a.x+a.y*a.y+a.z*a.z);
    }

    public static float GetAngleX(Vector3 begining, Vector3 ending)
    {
        float angle, dy, dz; //test
        dy = ending.y - begining.y;
        dz = ending.z - begining.z;
        if (Mathf.Sqrt(dy * dy + dz * dz) == 0) angle = 0;
        else angle =  dy / Mathf.Sqrt(dy * dy + dz * dz);
        return Mathf.Asin(angle) * Mathf.Rad2Deg; 
    }
    public static float GetAngleY(Vector3 begining, Vector3 ending)
    {
        float angle, dx, dz;
        dx = ending.x - begining.x;
        dz = ending.z - begining.z;
        if (Mathf.Sqrt(dx * dx + dz * dz) == 0) angle = 0;
        else angle = dx / Mathf.Sqrt(dx * dx + dz * dz);
        return Mathf.Asin(angle) * Mathf.Rad2Deg;
    }
    public static float GetAngleZ(Vector3 begining, Vector3 ending)
    {
        float angle, dy, dx; //test
        dy = ending.y - begining.y;
        dx = ending.x - begining.x;
        if (Mathf.Sqrt(dx * dx + dy * dy) == 0) angle = 0;
        else angle = dy / Mathf.Sqrt(dx * dx + dy * dy);
        return Mathf.Asin(angle) * Mathf.Rad2Deg;
    }

    public static Vector3 Normalize(Vector3 a)
    {
        float k;
        float max = Mathf.Max(a.x, a.y, a.z);
        k = 1/Mathf.Sqrt(((a.x/max)*(a.x / max)) + ((a.y / max) * (a.y / max)) + ((a.z / max) * (a.z / max)));
        return new Vector3(k*a.x/max, k * a.y / max, k * a.z / max);
    }

}
