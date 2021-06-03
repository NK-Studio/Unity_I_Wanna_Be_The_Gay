using GameplayIngredients;
using UnityEngine;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
using System.IO;
using System;

public class GameManager : Manager
{
    public UIP uip { get; private set; }

    private GameData[] gameDatas = new GameData[3];

    private string datapath;

    [NonSerialized]
    public int CurrentGameIndex = 0;

    private void Awake()
    {
        uip = new UIP();
        uip.System.FullScreen.performed += _ => { Screen.fullScreen = !Screen.fullScreen; };
        uip.System.GameEnd.performed += _ => { Application.Quit(); };

        Application.targetFrameRate = 50;

        datapath = $"{Application.dataPath}IWBT_save.json";

        OnLoad();
    }


    private void OnEnable() => uip.Enable();

    private void OnDisable() => uip.Disable();

    private void OnSave(int id = -1, GameData? data = null)
    {
        if (id == -1 || data != null)
            gameDatas[id] = data.Value;

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
