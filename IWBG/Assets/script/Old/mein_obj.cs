using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mein_obj : MonoBehaviour {

    private int up_down = 0;
    public Sprite[] start = new Sprite[2];
    public Sprite[] data = new Sprite[2];
    public Sprite[] option = new Sprite[2];
    public Sprite[] end = new Sprite[2];
    public SpriteRenderer[] spr = new SpriteRenderer[4];
    public AudioSource aud;
    public AudioClip ent,wow;
    public GameObject load_map;

    private void enter_efect()
    {
        switch (up_down)
        {
            case 0:
                string room = PlayerPrefs.GetString("room", "difficulty_room");
                if (room != "difficulty_room")
                {
                    Instantiate(load_map);
                }
                else
                {
                    gameObject.GetComponent<room_goto_scr>().room_goto("difficulty_room");
                }
                break;
            case 1:
                PlayerPrefs.DeleteAll();
                break;
            case 2:
                Application.Quit();
                break;
        }
    }

    private void Update()
    {
        chek();
        if (Input.GetKeyDown(KeyCode.Return))
        {
            world.instance.Game_effect.PlayOneShot(ent);
            enter_efect();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (up_down != 0)
            {
                aud.PlayOneShot(wow);
                reset_i();
                up_down -= 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (up_down != 2)
            {
                aud.PlayOneShot(wow);
                reset_i();
                   up_down += 1;
            }
        }

        switch (up_down)
        {
            case 0:
                Vector2 up_down1 =  transform.position;
                up_down1.y = 0.8f;
                transform.position = up_down1;
                break;
            case 1:
                Vector2 up_down2 = transform.position;
                up_down2.y = 0f;
                transform.position = up_down2;
                break;
                 case 2:
                Vector2 up_down4 = transform.position;
                up_down4.y = -2.24f;
                transform.position = up_down4;
                break;
        }
    }

    private void reset_i()
    {
        spr[0].sprite = start[0];
        spr[1].sprite = data[0];
       spr[3].sprite = end[0];
    }

    private void chek()
    {
        switch (up_down)
        {
            case 0:
                spr[0].sprite = start[1];
                break;
            case 1:
                spr[1].sprite = data[1];
                break;
            case 2:
                spr[3].sprite = end[1];
                break;
        }
    }
}
