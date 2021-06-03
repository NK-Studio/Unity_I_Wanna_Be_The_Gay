using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager GetInstance
    {
        get
        {
            if (instance == null)
            {
                var obj = FindObjectOfType<GameManager>();
                if (obj != null)
                    instance = obj;
                else
                {
                    var newobj = new GameObject("GameManager").AddComponent<GameManager>();
                    instance = newobj;
                }
            }
            return instance;
        }
    }

    public UIP uip { get; private set; }

    public GameData[] gameDatas = new GameData[3];

    private string datapath;

    [NonSerialized]
    public static int CurrentGameIndex = 0;

    private void Awake()
    {
        #region Singleton

        var objs = FindObjectsOfType<GameManager>();

        if (objs.Length != 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        #endregion

        uip = new UIP();
        uip.System.FullScreen.performed += _ => { Screen.fullScreen = !Screen.fullScreen; };
        uip.System.GameEnd.performed += _ => { Application.Quit(); };

        Application.targetFrameRate = 50;

        datapath = $"{Application.dataPath}IWBT_save.json";

        OnLoad();
    }

    public void OnSave(int id = -1, GameData? data = null)
    {
        //바뀐 내용이 있으면 그것을 반영함
        if (id != -1 && data != null)
            gameDatas[id] = data.Value;

        //데이터를 저장
        var json = JsonConvert.SerializeObject(gameDatas, Formatting.Indented);
        File.WriteAllText(datapath, json);
    }

    private void OnLoad()
    {
        var Check = File.Exists(datapath);
        if (!Check) return;

        var json = File.ReadAllText(datapath);
        gameDatas = JsonConvert.DeserializeObject<GameData[]>(json);
    }
}
