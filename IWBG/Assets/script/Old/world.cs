using UnityEngine;
using UnityEngine.SceneManagement;

public class world : MonoBehaviour
{
    public bool bgm_onoff;
    public bool eff_onoff;

    public static world instance { get; set; }

    public AudioClip[] audio_effect;
    public AudioClip[] audio_bgm;

    [Header("sound")]
    public AudioSource Game_bgm, Game_effect, Kill_bgm;

    public GameObject restart;

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

        //player.GetComponent<player>().PlayerData.blood.SetActive(true);

        if (GameObject.Find("game_end_message(Clone)") == null)
        {

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

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!(SceneManager.GetActiveScene().buildIndex >= 0 && SceneManager.GetActiveScene().buildIndex <= 6))
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
