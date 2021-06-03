using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_boss_expler : MonoBehaviour {

    public GameObject pa;
    public GameObject change_boss;

    [Header("ui_change")]
    public GameObject hp_bar;
    public GameObject dialog;

    public GameObject exp;
	// Use this for initialization
	void Start () {
        StartCoroutine("exploer");
        StartCoroutine("end");
    }
	
IEnumerator exploer()
    {
      GameObject temp =  Instantiate(exp);
        temp.transform.position = new Vector2(Random.Range(transform.position.x-0.5f, transform.position.x + 0.5f), Random.Range(transform.position.y - 0.5f, transform.position.y + 0.5f));
        yield return new WaitForSeconds(Random.Range(0.2f,0.25f));
        StartCoroutine("exploer");
    }
    IEnumerator end()
    {
        yield return new WaitForSeconds(5f);
        hp_bar.SetActive(false);
        dialog.SetActive(true);
        change_boss.SetActive(true);
        pa.SetActive(false);
    }
}
