using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_dore : MonoBehaviour {

    public GameObject box;

    private void Update() {
        if (GameObject.Find("player")) {
            box.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D coll)
    {
        if(coll.gameObject.name == "player")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Application.LoadLevel(Application.loadedLevel + 1);
            }
        }
    }
}
