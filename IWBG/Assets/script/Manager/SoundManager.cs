using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;

    public static SoundManager GetInstance
    {
        get
        {
            if (instance == null)
            {
                var obj = FindObjectOfType<SoundManager>();
                if (obj != null)
                    instance = obj;
                else
                {
                    var newobj = new GameObject("SoundManager").AddComponent<SoundManager>();
                    instance = newobj;
                }
            }
            return instance;
        }
    }

    private AudioSource bgm;
    private AudioSource sfx;

    private void Awake()
    {
        #region Singleton

        var objs = FindObjectsOfType<SoundManager>();

        if (objs.Length != 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        //사운드 자식을 붙임
        var BGM = new GameObject().AddComponent<AudioSource>();
        BGM.transform.parent = transform;
        bgm = BGM;

        var SFX = new GameObject().AddComponent<AudioSource>();
        SFX.playOnAwake = false;
        SFX.transform.parent = transform;
        sfx = SFX;

        #endregion
    }
}