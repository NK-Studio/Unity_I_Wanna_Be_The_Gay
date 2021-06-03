using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class load_image : MonoBehaviour
{

    private void Start()
    {
        Invoke("next", 3.7f);

        if (GameObject.Find("RCamera") != null)
        {
            Vector2 pl_position = GameObject.Find("RCamera").GetComponent<obj_camera>().result_xy;
            Vector2 temp_xy = gameObject.transform.position;
            temp_xy.x = pl_position.x;
            temp_xy.y = pl_position.y;
            gameObject.transform.position = temp_xy;
        }

    }
    void Update()
    {
        if (name != "load_image_ui")
        {
            Vector2 sc = gameObject.transform.localScale;
            sc.x += 0.18f;
            sc.y += 0.18f;
            gameObject.transform.localScale = sc;
        }
        else
        {
            Vector2 sc = gameObject.GetComponent<RectTransform>().localScale;
            sc.x += 0.18f;
            sc.y += 0.18f;
            gameObject.GetComponent<RectTransform>().localScale = sc;
        }
    }
}
