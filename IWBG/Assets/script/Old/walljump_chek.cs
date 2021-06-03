using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walljump_chek : MonoBehaviour {

    public obj_Walljump obj;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "player")
        {
            obj.area = true;
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            obj.area = false;
        }
    }
}
