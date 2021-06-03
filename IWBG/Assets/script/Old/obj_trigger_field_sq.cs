using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_trigger_field_sq : MonoBehaviour {

    public bool Active = false;
    public SpriteRenderer spr;

    private void Start()
    {
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
