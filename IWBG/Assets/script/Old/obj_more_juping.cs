using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_more_juping : MonoBehaviour {

    public GameObject effect;

    public SpriteRenderer spr;

    public bool my_type = true;

    private bool my_posy = false;
    private float sup = 0f;

    public void MJ_Invisible()
    {
        spr.color = new Color(1, 1, 1, 0);
        Invoke("MJ_see", 1.2f);
    }

    public void MJ_see()
    {
        my_type = true;
        spr.color = new Color(1, 1, 1, 1);
    }

    private void FixedUpdate()
    {
        float movef = 0.005f;
        float movef2 = 0.05f;
        if (my_posy == false)
        {
            Vector2 updown = transform.position;
            updown.y += movef;
            sup += movef;
            transform.position = updown;
        }
        else
        {
            Vector2 updown = transform.position;
            updown.y -= movef;
            sup -= movef;
            transform.position = updown;
        }

            if (sup > movef2)
            {
                my_posy = true;
                sup = movef2;
    }

        if (sup < -movef2)
        {
            my_posy = false;
            sup = -movef2;
        }



    }
}
