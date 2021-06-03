using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_bullet_move : MonoBehaviour {

    [HideInInspector]
    public Vector2 my_go;

    public Vector2 left_right,up_down;

    public bool move_ment = false;

    public bool collider_big;

    [Header("collider_chek")]
    public bool capsul;
    public bool box;
    public bool poligon;


    private void FixedUpdate() {
        if(collider_big == true)
        {
            GameObject player = GameObject.Find("player");
            if (player != null)
            {
                if (player.transform.position.x - 0.5f < transform.position.x && player.transform.position.x + 0.5f > transform.position.x &&
                    player.transform.position.y - 0.5f < transform.position.y && player.transform.position.y + 0.5f > transform.position.y)
                {//가시가 플레이어의 특정 범위에 있을 경우
                    if (capsul == true)
                    {
                        gameObject.GetComponent<CapsuleCollider2D>().enabled = true;
                    }
                    if (box == true)
                    {
                        gameObject.GetComponent<BoxCollider2D>().enabled = true;
                    }
                    if (poligon == true)
                    {
                    gameObject.GetComponent<PolygonCollider2D>().enabled = true;
                    }
                }
                else
                {//가시가 플레이어의 특정 범위에 있을 경우
                    if (capsul == true)
                    {
                        gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
                    }
                    if (box == true)
                    {
                        gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    if (poligon == true)
                    {
                        gameObject.GetComponent<PolygonCollider2D>().enabled = false;
                    }
                }
            }
        }

        if(move_ment == true) {
        Vector2 my_move = transform.position;
        my_move.x += my_go.x;
        my_move.y += my_go.y;
        transform.position = my_move;
        }

        if(transform.position.x <left_right.x || transform.position.x > left_right.y || transform.position.y > up_down.x || transform.position.y< up_down.y) {
            Destroy(gameObject);
        }
    }
}
