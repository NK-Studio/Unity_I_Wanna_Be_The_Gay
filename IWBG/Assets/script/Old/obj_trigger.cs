using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_trigger : MonoBehaviour {

    public SpriteRenderer spr;
    public bool Active = false;

    private void Start()
    {
        spr.color = new Color(1, 1, 1, 0);
    }

    private void OnTriggerStay2D(Collider2D coll)
    {
        switch (coll.gameObject.tag)
        {
            case "player":
                Active = true;
                break;

            case "trigger_background":
                if (Active == true)
                {
                    coll.GetComponent<obj_trigger_field_sq>().Active = true;
                }
                break;
        }
    }
}
