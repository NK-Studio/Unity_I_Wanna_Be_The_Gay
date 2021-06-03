using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoke_effect : MonoBehaviour {

    public GameObject smo;

    private void Start()
    {
       Invoke("create", 0.01f);
    }
    private void create()
    {
  //      GameObject temp = Instantiate(smo);
//        temp.gameObject.transform.position = gameObject.transform.position;
        Invoke("create", 0.01f);
    }

    private void Update()
    {
        GameObject temp = Instantiate(smo);
        temp.gameObject.transform.position = gameObject.transform.position;

        GameObject player = GameObject.Find("player");
        if(player != null)
        {
        Vector2 myxy = gameObject.transform.position;
        myxy.x = player.gameObject.GetComponent<Transform>().position.x;
        myxy.y = player.gameObject.GetComponent<Transform>().position.y-0.2f;
        gameObject.transform.position = myxy;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
