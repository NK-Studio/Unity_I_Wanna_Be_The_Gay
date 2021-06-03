using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_spin_bullet_1 : MonoBehaviour {

    [Header("private value")]
    Vector2 v1, v2;


    public int angle_1 = 0;

    public int angle_2 = 0;

     public GameObject obj_bullet;

    public float speed = 3f;

    IEnumerator Alarm0(float time)
    {
        if (GameObject.Find("obj_bullet_spin_centa") != null)
        {
            if (GameObject.Find("obj_bullet_spin_target") != null)
            {
                sc_shot(0);
                sc_shot(90);
                sc_shot(180);
                sc_shot(270);

                sc_shot_2(0);
                sc_shot_2(90);
                sc_shot_2(180);
                sc_shot_2(270);
            }
        }
        angle_1 += 10;//4방향 회전에 10도 씩 변화가 생기도록 값을 넣어줌
        angle_2 += 28;//4방향 회전에 28도 씩 변화가 생기도록 값을 넣어줌
        yield return new WaitForSeconds(time);
        StartCoroutine("Alarm0", 0.15f);
    }

    private void sc_shot(int r) {
        GameObject.Find("obj_bullet_spin_centa").transform.rotation = Quaternion.Euler(0, 0, r + angle_1);
        v1 = GameObject.Find("obj_bullet_spin_centa").transform.position;
        v2 = GameObject.Find("obj_bullet_spin_target").transform.position;

        Vector2 dir = v2 - v1;
        dir.Normalize();

        GameObject temp = Instantiate(obj_bullet, transform.position, Quaternion.identity);
        temp.GetComponent<obj_bullet_move>().my_go = new Vector2(dir.x * Time.deltaTime * speed, dir.y * Time.deltaTime * speed);
        temp.GetComponent<sc_direction>().my_z = new Vector3(0, 0, GameObject.Find("obj_bullet_spin_centa").transform.eulerAngles.z);
        temp.GetComponent<sc_direction>().cullent_my_z();
    }

    private void sc_shot_2(int r) {
        GameObject.Find("obj_bullet_spin_centa").transform.rotation = Quaternion.Euler(0, 0, r + angle_2);
        v1 = GameObject.Find("obj_bullet_spin_centa").transform.position;
        v2 = GameObject.Find("obj_bullet_spin_target").transform.position;

        Vector2 dir = v2 - v1;
        dir.Normalize();

        GameObject temp = Instantiate(obj_bullet, transform.position, Quaternion.identity);
        temp.GetComponent<obj_bullet_move>().my_go = new Vector2(dir.x * Time.deltaTime * speed, dir.y * Time.deltaTime * speed);
        temp.GetComponent<sc_direction>().my_z = new Vector3(0, 0, GameObject.Find("obj_bullet_spin_centa").transform.eulerAngles.z);
        temp.GetComponent<sc_direction>().cullent_my_z();
    }
}
