using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum  MoveType
{
    UP,DOWN,LEFT,RIGHT,FEST,SLOW,STOP 
}

public class obj_trigger_system : MonoBehaviour
{

    public MoveType type;
    private SpriteRenderer spr;
    public bool Active = false;

    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        spr.color = new Color(1, 1, 1, 0);
    }

    private void OnTriggerStay2D(Collider2D coll)
    {
        switch (coll.gameObject.tag)
        {
            case "trigger_background":
                if (coll.GetComponent<obj_trigger_field_sq>().Active == true)
                {
                   Active = true;
                }
                break;
        }
    }

}
