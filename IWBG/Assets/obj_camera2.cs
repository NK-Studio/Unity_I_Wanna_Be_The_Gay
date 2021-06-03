using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_camera2 : MonoBehaviour {

	void Update () {

        GameObject player = GameObject.Find("player_sinsu");

        if (player != null)
        {
            Vector3 ud = transform.position;
            ud.y = player.transform.position.y;

            if (player.transform.position.y > 0.02f && ud.y < 12f)
            {
                transform.position = ud;
            }

        }

    }
}
