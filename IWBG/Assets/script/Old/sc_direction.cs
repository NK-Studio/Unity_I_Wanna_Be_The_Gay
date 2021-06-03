using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_direction : MonoBehaviour {

    [HideInInspector]
    public Vector3 my_z;

    public void cullent_my_z()
    {
        transform.eulerAngles = new Vector3(0, 0, my_z.z);
    }

public float getAngle(float x1,float y1, float x2, float y2) {
        float dx = x2 - x1;
        float dy = y2 - y1;

        float rad = Mathf.Atan2(dx, dy);
        float degree = rad * Mathf.Rad2Deg;

        return degree;
    }
}
