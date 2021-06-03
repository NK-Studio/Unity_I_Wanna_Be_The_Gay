using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_willjump_chek : MonoBehaviour {


    public L_willjump_sc obj;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("player"))
        {
            coll.gameObject.GetComponent<player>().PlayerData.l_will_jump = true;
            obj.area = true;
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("player"))
        {
            coll.gameObject.GetComponent<player>().PlayerData.l_will_jump = false;
            obj.area = false;
        }
    }
}
