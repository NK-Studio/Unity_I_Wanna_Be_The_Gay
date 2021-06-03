using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_tric : MonoBehaviour
{
    public Rigidbody2D rig;

    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("trigger_green"))
        {
            switch (coll.GetComponent<obj_trigger_system>().type)
            {
                case MoveType.DOWN:
                    if (coll.GetComponent<obj_trigger_system>().Active == true && rig.velocity.y == 0)
                    {
                        rig.velocity = new Vector2(0, -8);
                        coll.gameObject.SetActive(false);
                    }
                    break;
                case MoveType.UP:
                    if (coll.GetComponent<obj_trigger_system>().Active == true && rig.velocity.y == 0)
                    {
                        rig.velocity = new Vector2(0, 8);
                        coll.gameObject.SetActive(false);
                    }
                    break;
                case MoveType.LEFT:
                    if (coll.GetComponent<obj_trigger_system>().Active == true && rig.velocity.x == 0)
                    {
                        rig.velocity = new Vector2(-8, 0);
                        coll.gameObject.SetActive(false);
                    }
                    break;
                case MoveType.RIGHT:
                    if (coll.GetComponent<obj_trigger_system>().Active == true && rig.velocity.x == 0)
                    {
                        rig.velocity = new Vector2(8, 0);
                        coll.gameObject.SetActive(false);
                    }
                    break;
                case MoveType.FEST:
                    if (rig.velocity.x != 0 || rig.velocity.y != 0)
                    {
                        rig.velocity = new Vector2(rig.velocity.x * 2, rig.velocity.y);
                        rig.velocity = new Vector2(rig.velocity.x, rig.velocity.y * 2);
                        coll.gameObject.SetActive(false);
                    }
                    break;
                case MoveType.SLOW:
                    if (rig.velocity.x != 0 || rig.velocity.y != 0)
                    {
                        rig.velocity = new Vector2(rig.velocity.x / 2, rig.velocity.y);
                        rig.velocity = new Vector2(rig.velocity.x, rig.velocity.y / 2);
                        coll.gameObject.SetActive(false);
                    }
                    break;
                case MoveType.STOP:
                    rig.velocity = Vector2.zero;
                    coll.gameObject.SetActive(false);
                    break;
            }
        }
    }
}