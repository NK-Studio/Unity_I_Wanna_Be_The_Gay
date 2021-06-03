using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_Walljump : MonoBehaviour
{
    public bool area = false;

    public AudioSource and;

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("player"))
        {
            coll.gameObject.GetComponent<player>().anim.SetBool("sliding", false);
        }
    }

    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("player"))
        {
            if (coll.gameObject.GetComponent<Rigidbody2D>().velocity.x == 0)
            {
                if (area == true)
                {
                        coll.gameObject.GetComponent<player>().PlayerData.frozen = 2;

                    coll.gameObject.GetComponent<player>().anim.SetBool("jump", false);
                    coll.gameObject.GetComponent<player>().anim.SetBool("fall", false);
                    coll.gameObject.GetComponent<player>().anim.SetBool("sliding", true);

                    coll.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;

                    Vector2 down = coll.gameObject.GetComponent<Rigidbody2D>().velocity;
                    down.y = -1.2f;
                    coll.gameObject.GetComponent<Rigidbody2D>().velocity = down;

                    Vector2 scaile = coll.gameObject.GetComponent<Transform>().localScale;

                    if (scaile.x == 1)
                    {
                        coll.gameObject.GetComponent<Transform>().localScale = new Vector2(1, 1);

                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            Vector2 left = coll.gameObject.GetComponent<Rigidbody2D>().velocity;
                                left.x = -1;
                            coll.gameObject.GetComponent<Rigidbody2D>().velocity = left;
                            and.Play();
                            if (Input.GetKey(KeyCode.Z))
                            {
                                Vector2 up = coll.gameObject.GetComponent<Rigidbody2D>().velocity;
                                    up.y = 4;
                                coll.gameObject.GetComponent<Rigidbody2D>().velocity = up;
                            }
                            else
                            {
                                Vector2 up = coll.gameObject.GetComponent<Rigidbody2D>().velocity;
                                    up.y = 2;
                                coll.gameObject.GetComponent<Rigidbody2D>().velocity = up;
                            }
                        }
                    }
                    else
                    {
                        coll.gameObject.GetComponent<Transform>().localScale = new Vector2(-1, 1);

                        if (Input.GetKey(KeyCode.RightArrow))
                        {
                            coll.gameObject.GetComponent<player>().PlayerData.frozen = 2;
                            Vector2 right = coll.gameObject.GetComponent<Rigidbody2D>().velocity;
                                right.x = 1;
                            coll.gameObject.GetComponent<Rigidbody2D>().velocity = right;
                            and.Play();

                            if (Input.GetKey(KeyCode.Z))
                            {
                                Vector2 up = coll.gameObject.GetComponent<Rigidbody2D>().velocity;
                                    up.y = 4;
                                coll.gameObject.GetComponent<Rigidbody2D>().velocity = up;
                            }
                            else
                            {
                                Vector2 up = coll.gameObject.GetComponent<Rigidbody2D>().velocity;
                                    up.y = 2;
                                coll.gameObject.GetComponent<Rigidbody2D>().velocity = up;
                            }
                        }
                    }
                }
            }
        }
    }
}
