using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_end_message : MonoBehaviour {

    public SpriteRenderer spr;
	void Start () {
        int dth = PlayerPrefs.GetInt("player_death", 0);
        dth = dth += 1;
        PlayerPrefs.SetInt("player_death", dth);
        Invoke("realA", 0.3f);
	}

    private void realA()
    {
        spr.color = new Color(1, 1, 1, 1);
    }


}
