using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_bload : MonoBehaviour {

    public Sprite[] p = new Sprite[3];
    public SpriteRenderer spr;

    private bool stop = false;

    private float dir_x;
    private float dir_up = 0;
    private float dir_gravity = 0f;
    private void Start()
    {
        dir_up = Random.RandomRange(0.1f, 0.3f);
        dir_x = Random.RandomRange(-0.1f, 0.1f);
        int i = Random.RandomRange(0, 3);

        spr.sprite = p[i];
    }
    private void FixedUpdate()
    {
        if(stop == false)
        {
            Vector2 dir = transform.position;
            dir.x += dir_x;
            transform.position = dir;
            if(dir_gravity < 0.8f)
            {
            dir_gravity += 0.02f;
            }
        Vector2 gravity = transform.position;
            gravity.y += dir_up- dir_gravity;
        transform.position = gravity;

        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "isGround")
        {
            stop = true;

        }
    }


}
