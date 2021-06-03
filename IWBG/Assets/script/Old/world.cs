using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum diffent
{
    NONE,
    ESAY,
    MEDIUM,
    HARD,
    VERYHARD
}

public class world : MonoBehaviour
{
    [HideInInspector]
    public diffent dificult = diffent.NONE;

    public bool bgm_onoff;
    public bool eff_onoff;

    public static world instance { get; set; }

    public AudioClip[] audio_effect;
    public AudioClip[] audio_bgm;

    [Header("sound")]
    public AudioSource Game_bgm, Game_effect, Kill_bgm;

    public GameObject restart;

    public void new_music(string room)
    {
        //   Game_bgm.clip = audio_bgm[4];
        //  Game_bgm.Play();
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        Screen.SetResolution(800, 608, false);

        SceneManager.LoadScene("tuto");
    }

    public void kill_player(GameObject player)
    {
        //화면에 총알이 1개라도 있을 경우
        GameObject[] bullet_delete = GameObject.FindGameObjectsWithTag("bullet");

        //다중 제거
        if (bullet_delete.Length > 0)
        {
            for (int b = 0; b < bullet_delete.Length; b++)
            {
                Destroy(bullet_delete[b]);
            }
        }

        player.GetComponent<player>().PlayerData.blood.SetActive(true);

        if (GameObject.Find("game_end_message(Clone)") == null)
        {
            //    GameObject temp = Instantiate(player.GetComponent<player>().game_over_msg);

            //    player.SetActive(false);

            Vector2 pl_position = GameObject.Find("RCamera").GetComponent<obj_camera>().result_xy;

//            Vector2 temp_xy = temp.gameObject.transform.position;
//            temp_xy.x = pl_position.x;
//            temp_xy.y = pl_position.y;
//            temp.transform.position = temp_xy;
        }
//        Game_bgm.Pause();
//        Kill_bgm.clip = audio_bgm[1];
//        Kill_bgm.Play();
//        Kill_bgm.loop = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F4))
        {
            Screen.fullScreen = !Screen.fullScreen;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!(Application.loadedLevel >= 0 && Application.loadedLevel <= 6))
            {
                Kill_bgm.Stop();
                Instantiate(restart);
            }
        }

        if (Input.GetKeyDown(KeyCode.Exclaim))
        {
            Application.Quit();
        }
    }
}
