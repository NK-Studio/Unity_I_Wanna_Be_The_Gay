using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_potal : MonoBehaviour {

    public SpriteRenderer spr;
    public Sprite sp;
    public AudioSource aud;
    public GameObject load;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("player"))
        {
            world.instance.Game_bgm.Stop();
            spr.sprite = sp;
            aud.Play();
            Instantiate(load);
        }
    }

    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("player"))
        {
            coll.gameObject.GetComponent<player>().anim.SetBool("fall", true);
            coll.gameObject.GetComponent<player>().anim.SetBool("jump", false);
            coll.gameObject.GetComponent<player>().anim.SetBool("isGround", false);
            coll.gameObject.GetComponent<player>().PlayerData.enable = true;
            coll.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            coll.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;

        }
    }
}
