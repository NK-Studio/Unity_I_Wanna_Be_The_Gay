using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_change_boss : MonoBehaviour {

    public float speed, w_h;
    private Vector2 h_left, h_right, v_up, v_down;
    public bool chek;
    public Rigidbody2D rig;
    private bool ownshot = false;


    private void Start()
    {
        world.instance.Game_bgm.clip = world.instance.audio_bgm[7];
        world.instance.Game_bgm.Play();


        h_left = new Vector2(transform.position.x - w_h, transform.position.y);
        h_right = new Vector2(transform.position.x + w_h, transform.position.y);
        v_up = new Vector2(transform.position.x, transform.position.y + w_h);
        v_down = new Vector2(transform.position.x, transform.position.y - w_h);

        if (GameObject.Find("player") != false)
        {
            GameObject.Find("player").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        GameObject.Find("player").GetComponent<player>().PlayerData.enable = true;
        }
    }
    private float a = 1;
	// Update is called once per frame
	void Update () {
        a -= 0.02f;
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1,a);


        if (chek == false)
        {
            if (v_up.y > transform.position.y)
            {
                if (ownshot == false)
                {
                    rig.AddForce(new Vector2(0, speed));
                }
            }
            if (v_up.y - 0.05f < transform.position.y)
            {
                rig.velocity = new Vector2(0, 0);
                chek = true;
            }
        }
        else
        {
            if (v_down.y < transform.position.y)
            {
                rig.AddForce(new Vector2(0, -speed));
            }
            if (v_down.y + 0.05f > transform.position.y)
            {
                rig.velocity = new Vector2(0, 0);
                chek = false;
            }

        }
    }
}
