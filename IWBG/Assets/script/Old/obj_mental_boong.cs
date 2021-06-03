using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_mental_boong : MonoBehaviour {

    public Vector2 end;
    private Vector2 my;

    public bool up_down = false;

	// Use this for initialization
	void Start () {
        my = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if(up_down == false) {
        transform.position = Vector2.Lerp(transform.position, end,0.05f);
        }else if (up_down == true)
            transform.position = Vector2.Lerp(transform.position, my, 0.05f);

        if (transform.position.y < my.y + 0.05f) {
            gameObject.GetComponentInChildren<obj_spin_bullet_1>().angle_1 = 0;
            gameObject.GetComponentInChildren<obj_spin_bullet_1>().angle_2 = 0;
            up_down = false;
            gameObject.SetActive(false);
        }
    }
}
