using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star_effect : MonoBehaviour {

    public int type; 
    public Rigidbody2D rig;

    private void Start()
    {
        float speed = 2f;
        switch (type)
        {
            
            case 0:
                rig.velocity = Vector2.up * speed;
                break;
            case 1:
                rig.velocity = Vector2.left * speed;
                break;
            case 2:
                rig.velocity = Vector2.right * speed;
                break;
            case 3:
                rig.velocity = Vector2.down * speed;
                break;
            case 4:
                rig.velocity = new Vector2(speed, speed);
                break;
            case 5:
                rig.velocity = new Vector2(-speed, -speed);
                break;
            case 6:
                rig.velocity = new Vector2(-speed, speed);
                break;
            case 7:
                rig.velocity = new Vector2(speed, -speed);
                break;
        }
    }

    void Update () {
        Vector2 sc = gameObject.transform.localScale;
        sc.x -= 0.05f;
        sc.y -= 0.05f;
        gameObject.transform.localScale = sc;

        if(sc.x <= 0)
        {
            Destroy(gameObject);
        }
    }
}
