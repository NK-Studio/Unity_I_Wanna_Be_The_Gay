using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_difficult_chose : MonoBehaviour {

    private int up_down = 0;
    public Sprite[] start = new Sprite[2];
    public Sprite[] data = new Sprite[2];
    public Sprite[] option = new Sprite[2];
    public Sprite[] end = new Sprite[2];
    public SpriteRenderer[] spr = new SpriteRenderer[4];
    public AudioSource aud;
    public AudioClip ent,wow;

    private void enter_efect()
    {
        switch (up_down)
        {
            case 0:
                PlayerPrefs.SetString("diffcult", "EASY");
                GameObject.Find("world").GetComponent<world>().dificult = diffent.ESAY;
                PlayerPrefs.SetInt("dificult", (int)GameObject.Find("world").GetComponent<world>().dificult);
                world.instance.Game_bgm.Stop();
                gameObject.GetComponent<room_goto_scr>().room_goto("first_story");
                break;
            case 1:
                PlayerPrefs.SetString("diffcult", "NOLMAL");
                GameObject.Find("world").GetComponent<world>().dificult = diffent.MEDIUM;
                PlayerPrefs.SetInt("dificult", (int)GameObject.Find("world").GetComponent<world>().dificult);
                world.instance.Game_bgm.Stop();
                gameObject.GetComponent<room_goto_scr>().room_goto("first_story");
                break;
            case 2:
                PlayerPrefs.SetString("diffcult", "HARD");
                GameObject.Find("world").GetComponent<world>().dificult = diffent.HARD;
                PlayerPrefs.SetInt("dificult", (int)GameObject.Find("world").GetComponent<world>().dificult);
                world.instance.Game_bgm.Stop();
                gameObject.GetComponent<room_goto_scr>().room_goto("first_story");
                break;
            case 3:
                PlayerPrefs.SetString("diffcult", "IMPOSSIBLE");
                GameObject.Find("world").GetComponent<world>().dificult = diffent.VERYHARD;
                PlayerPrefs.SetInt("dificult", (int)GameObject.Find("world").GetComponent<world>().dificult);
                world.instance.Game_bgm.Stop();
                gameObject.GetComponent<room_goto_scr>().room_goto("first_story");
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
            if (up_down != 3)
            {
                aud.PlayOneShot(wow);
                reset_i();
                up_down += 1;
            }
        }

        switch (up_down)
        {
            case 0:
                Vector2 up_down1 = transform.position;
                up_down1.y = 1.12f;
                transform.position = up_down1;
                break;
            case 1:
                Vector2 up_down2 = transform.position;
                up_down2.y = 0f;
                transform.position = up_down2;
                break;
            case 2:
                Vector2 up_down3 = transform.position;
                up_down3.y = -1.12f;
                transform.position = up_down3;
                break;
            case 3:
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
        spr[2].sprite = option[0];
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
                spr[2].sprite = option[1];
                break;
            case 3:
                spr[3].sprite = end[1];
                break;
        }
    }
}