using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_bullet_cicle : MonoBehaviour {
    [Header("Project setting")]
    public float speed; //스피드 값
    public GameObject prepap; //총알

    [Header("private value")]
    Vector2 v1, v2;

    public void span() {
        if(GameObject.Find("obj_bullet_spin_centa") != null) {
            if(GameObject.Find("obj_bullet_spin_target") != null) {
                for(int i = 0; i< 360; i += 10) {//360도중에 10의 배수에만 진행됨
                GameObject.Find("obj_bullet_spin_centa").transform.rotation = Quaternion.Euler(0, 0, i);
             v1 = GameObject.Find("obj_bullet_spin_centa").transform.position;
             v2 = GameObject.Find("obj_bullet_spin_target").transform.position;
                Vector2 dir = v2 - v1;//방향을 구함
                dir.Normalize();
                GameObject temp = Instantiate(prepap, transform.position, Quaternion.identity);
                temp.GetComponent<Rigidbody2D>().velocity = new Vector2(dir.x*speed, dir.y * speed);//방향과 속도를 넣어줌
                   temp.GetComponent<sc_direction>().my_z = new Vector3(0, 0, GameObject.Find("obj_bullet_spin_centa").transform.eulerAngles.z);
                    temp.GetComponent<sc_direction>().cullent_my_z();//총알의 각도를 넣어줌
                    Destroy(temp, 2.5f);//2.5초 후에 제거됨
                }
            }
          }
    }
    }
