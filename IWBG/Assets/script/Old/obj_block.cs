using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_block : MonoBehaviour {

    public SpriteRenderer spr;

    private void Start()
    {
        spr.color = new Color(1, 1, 1, 0);
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("bullet"))
        {
            Destroy(coll.gameObject);
        }
    }
    private void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("player"))
        {
            if(coll.gameObject.GetComponent<player>().PlayerData.smoke == 1)
            {
                if(coll.gameObject.GetComponent<Rigidbody2D>().velocity.y == 0)
                {
                    coll.gameObject.GetComponent<player>().PlayerData.smoke = 0;
                    coll.gameObject.GetComponent<player>().PlayerData.dobleJump = true;
                    Destroy(GameObject.Find("smoke_effect(Clone)"));
                }
            }
        }
    }
}
