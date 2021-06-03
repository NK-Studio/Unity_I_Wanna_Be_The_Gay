using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm_new_music : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        if (world.instance != null)
        {
            world.instance.new_music(Application.loadedLevelName);
        }
    }
}
