using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_white_effect : MonoBehaviour {

	// Use this for initialization
public void g_start()
    {
         Invoke("delte", 0.05f);
	}
    private void delte()
    {
        gameObject.SetActive(false);
    }
}
