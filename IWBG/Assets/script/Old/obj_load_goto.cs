using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_load_goto : MonoBehaviour
{
    public GameObject obj_player;
    private GameObject temp;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        string room = PlayerPrefs.GetString("room", "difficulty_room");
        Application.LoadLevel(room);
        Invoke("alarm0", 0.02f);
    }

    private void alarm0()
    {
        temp = GameObject.FindGameObjectWithTag("player");

        if (temp == null)
        {
            temp = Instantiate(obj_player);
        }


        float player_x = PlayerPrefs.GetFloat("player_x", 0);
        float player_y = PlayerPrefs.GetFloat("player_y", 0);
        float h = PlayerPrefs.GetFloat("player_h", 0);
        if (temp != null)
        {
            if (h < 0f)
            {
                temp.transform.localScale = new Vector2(-1, 1);
            }

            if (h > 0f)
            {
                temp.transform.localScale = new Vector2(1, 1);
            }

            temp.transform.position = new Vector2(player_x, player_y);
        }

        Destroy(this.gameObject);
    }
}
