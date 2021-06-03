using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_tuto_bullet : MonoBehaviour {

    public Rigidbody2D rig;
    private GameObject obj_target;

	// Use this for initialization
	void Start () {
        Invoke("player_go", 0.2f);
	}
private void player_go() {
        obj_target = GameObject.Find("player");
        if (obj_target != null) {
            Vector2 direction = obj_target.transform.position - transform.position;
            direction.Normalize();
            rig.velocity = direction * 5f;
            sc_direction sc_dir = GetComponent<sc_direction>();
            transform.eulerAngles= new Vector3(0, 0, -sc_dir.getAngle(transform.position.x, transform.position.y, obj_target.transform.position.x, obj_target.transform.position.y)-90f);
        }
        else
        {
            Vector3 null_player = new Vector3(-4.64f, -0.78f, 0);
            Vector2 direction = null_player - transform.position;
            direction.Normalize();
            rig.velocity = direction * 5f;
            sc_direction sc_dir = GetComponent<sc_direction>();
            transform.eulerAngles = new Vector3(0, 0, -sc_dir.getAngle(transform.position.x, transform.position.y, null_player.x, null_player.y) - 90f);
        }
    }

}
