using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cs_updown_effect : MonoBehaviour {


    public float speed, w_h;
    private Vector2 h_left, h_right, v_up, v_down;
    public bool chek;
    public bool h_type, v_type;
    public Rigidbody2D rig;
    private bool ownshot = false;

    private void Start()
    {
        h_left = new Vector2(transform.position.x - w_h, transform.position.y);

        h_right = new Vector2(transform.position.x + w_h, transform.position.y);

        v_up = new Vector2(transform.position.x, transform.position.y + w_h);

        v_down = new Vector2(transform.position.x, transform.position.y - w_h);
    }
    void Update()
    {

        if (h_type == true && v_type == true)
        {
            return;
        }

 
        if (h_type == true)
        {

            if (chek == false)
            {
                if (transform.position.x > h_left.x)
                {
                    if (ownshot == false)
                    {
                        rig.AddForce(new Vector2(-speed, 0));
                    }
                }
                if (transform.position.x < h_left.x + 0.05f)
                {
                    rig.velocity = new Vector2(0, 0);
                    chek = true;
                }
            }
            else
            {
                if (transform.position.x < h_right.x)
                {
                    rig.AddForce(new Vector2(speed, 0));
                }
                if (transform.position.x >h_right.x - 0.05f)
                {
                    rig.velocity = new Vector2(0, 0);
                    chek = false;
                }
            }
        }

        if (v_type == true)
            {
                if (chek == false)
                {
                    if (transform.position.y < v_up.y )
                    {
                        if (ownshot == false)
                        {
                            rig.AddForce(new Vector2(0, speed));
                        }
                    }
                    if (transform.position.y > v_up.y - 0.05f )
                    {
                        rig.velocity = new Vector2(0, 0);
                        chek = true;
                    }
                }
                else
                {
                    if (transform.position.y > v_down.y)
                    {
                        rig.AddForce(new Vector2(0, -speed));
                    }
                    if (transform.position.y < v_down.y + 0.05f)
                    {
                        rig.velocity = new Vector2(0, 0);
                        chek = false;
                    }

                }
            }
        }
}