using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_animaion_destory : MonoBehaviour {

public void des(int d)
    {
        if(d == 1)
        {
            Destroy(this.gameObject);
        }
    }
}
