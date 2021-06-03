using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_smoke_motion : MonoBehaviour {

    float a = 0;
    

    public SpriteRenderer spr;

    void Update () {

        Vector2 sc = gameObject.transform.localScale;
        sc.x -= 0.035f;
        sc.y -= 0.035f;
        gameObject.transform.localScale = sc;
       a += 0.035f;
        spr.color = new Color(1, 1, 1, a);

        if(gameObject.transform.localScale.x < 0f)
        {
            Destroy(gameObject);
        }
    }
}
