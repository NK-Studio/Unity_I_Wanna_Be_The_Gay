using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_bload_position : MonoBehaviour {

    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("player");
    }

    private void Update()
    {
        if(player != null)
        {
        transform.position = new Vector2(player.transform.position.x, player.transform.position.y);
        }
    }
}
