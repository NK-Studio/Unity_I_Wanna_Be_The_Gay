using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class obj_death : MonoBehaviour {

    private int death_nb;
    private string difft;
    public bool type;

    private void Update()
    {
        if(type == false)
        {
        death_nb = PlayerPrefs.GetInt("player_death", 0);

        gameObject.GetComponent<Text>().text = "Deaths : " + System.Convert.ToString(death_nb);
        }
        else
        {
            difft = PlayerPrefs.GetString("diffcult","Null");

            gameObject.GetComponent<Text>().text = "Diffcult : " + difft;
        }
    }
}
