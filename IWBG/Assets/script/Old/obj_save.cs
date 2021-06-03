using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_save : MonoBehaviour
{

    public GameObject save_ui;
    public int time = 0;
    public Sprite s1, s2;
    public SpriteRenderer spr;
    int type_change = 0;
    public AudioSource aus;

    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            if (GameObject.Find("spr_save_ui(Clone)") == null)
            {
                GameObject ui = Instantiate(save_ui);
                ui.transform.position = new Vector2(transform.position.x, transform.position.y + 0.3f);
            }

            if (aus.isPlaying == false)
            {
                aus.Play();
            }

            if (time == 0)
            {
                PlayerPrefs.SetFloat("player_x", coll.transform.position.x);
                PlayerPrefs.SetFloat("player_y", coll.transform.position.y);
                PlayerPrefs.SetFloat("player_h", coll.transform.localScale.x);
                PlayerPrefs.SetString("room", Application.loadedLevelName);
                spr.sprite = s2;
                type_change = 60;
                time = 30;
            }
        }
    }


    private void Update()
    {
        if (time > 0)
        {
            time -= 1;
            spr.sprite = s2;
        }
        else
        {
            spr.sprite = s1;
        }
    }
}
