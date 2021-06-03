using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room_goto_scr : MonoBehaviour {

    public bool type;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(type == true)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                room_goto_next();
            }
        }
	}

    public void room_goto_next()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    public void room_goto_previouse()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    public void room_goto(string room)
    {
        Application.LoadLevel(room);
    }
}
