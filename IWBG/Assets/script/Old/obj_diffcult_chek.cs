using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obj_diffcult_chek : MonoBehaviour
{
    public bool tpye = false; //false는 가시; trues는 생명 팩;
    
    public diffent diffcult;
    private void Update()
    {
        if(tpye == false)
        {
            if (world.instance.dificult < diffcult)
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            if (world.instance.dificult > diffcult)
            {
                gameObject.SetActive(false);
            }
        }
    }
}