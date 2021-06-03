using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_Earthquake : MonoBehaviour {

    private float a = 0;
    private float b = 0;
    private float c = 0;
    private float d = 0;

    void Start () {
        a = Random.Range(-0.05f, 0.05f);
        b = Random.Range(-0.05f, 0.05f);
        c = Random.Range(-0.05f, 0.05f);
        d = Random.Range(-0.05f, 0.05f);
        Invoke("alarm0", 1f);

    }
	private void alarm0()
    {
        if(GameObject.Find("RCamera") != null)
        {
        GameObject.Find("RCamera").transform.position = new Vector3(0, 0,-10);
        Destroy(gameObject);
        }
    }
	// Update is called once per frame
	void Update () {
        float xx = a-b;
        float yy = c-d;
        Vector3 chek = GameObject.Find("RCamera").transform.position = new Vector3(xx, yy,-10);
        a = Random.Range(-0.05f, 0.05f);
        b = Random.Range(-0.05f, 0.05f);
        c = Random.Range(-0.05f, 0.05f);
        d = Random.Range(-0.05f, 0.05f);
    }
}
