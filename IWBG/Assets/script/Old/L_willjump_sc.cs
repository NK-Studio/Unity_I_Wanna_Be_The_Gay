using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_willjump_sc : MonoBehaviour
{

    public string type;

    public bool area = false;

    public AudioSource and;

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("player"))
        {
            coll.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;

            if (coll.gameObject.GetComponent<player>().PlayerData.frozen == -1)
            {
                coll.gameObject.GetComponent<player>().PlayerData.frozen = 0;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("player"))
        {
            Rigidbody2D player_rig = coll.gameObject.GetComponent<Rigidbody2D>();
            player player = coll.gameObject.GetComponent<player>();

            if (area == true)
            {
                if (player_rig.velocity.x < 3)
                {
                    player.PlayerData.frozen = -1;
                }
                else if (player_rig.velocity.x > 3)
                {
                    player.PlayerData.frozen = -1;
                }

                if (player.PlayerData.frozen == -1)
                {
                    player.anim.SetBool("jump", false);
                    player.anim.SetBool("fall", false);
                    player.anim.SetBool("sliding", true);

                    player_rig.gravityScale = 0;

                    Vector2 down = coll.gameObject.GetComponent<Rigidbody2D>().velocity;
                    down.y = -1.2f;
                    player_rig.velocity = down;

                    if (type == "left")
                    {
                        coll.gameObject.GetComponent<Transform>().localScale = new Vector2(1, 1);

                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            player.anim.SetBool("sliding", false);
                            player.anim.SetBool("jump", false);
                            player.anim.SetBool("fall", true);
                            player.PlayerData.frozen = 50;
                            Vector2 left = player_rig.velocity;
                            left.x = -5;
                            left.y = 4f;
                            player_rig.velocity = left;
                            and.Play();
                        }
                    }
                    else if (type == "right")
                    {
                        coll.gameObject.GetComponent<Transform>().localScale = new Vector2(-1, 1);

                        if (Input.GetKey(KeyCode.RightArrow))
                        {
                            player. anim.SetBool("sliding", false);
                            player.anim.SetBool("jump", false);
                            player. anim.SetBool("fall", true);
                            player.PlayerData.frozen = 50;
                            Vector2 right = player_rig.velocity;
                            right.x = 5;
                            right.y = 4f;
                            player_rig.velocity = right;
                            and.Play();
                        }

                    }
                }
            }
        }
    }
}


