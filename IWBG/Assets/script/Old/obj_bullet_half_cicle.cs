using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_bullet_half_cicle : MonoBehaviour {

    [Header("Project setting")]
    public float speed;
    public GameObject prepap;

    [Header("private value")]
    Vector2 v1, v2;

    public void span(int r) {
        if(GameObject.Find("obj_bullet_spin_centa") != null) {
            if(GameObject.Find("obj_bullet_spin_target") != null) {
                GameObject.Find("obj_bullet_spin_centa").transform.rotation = Quaternion.Euler(0, 0,r);
             v1 = GameObject.Find("obj_bullet_spin_centa").transform.position;
             v2 = GameObject.Find("obj_bullet_spin_target").transform.position;
                Vector2 dir = v2 - v1;
                dir.Normalize();
                GameObject temp = Instantiate(prepap, transform.position, Quaternion.identity);
                temp.GetComponent<Rigidbody2D>().velocity = new Vector2(dir.x*speed, dir.y * speed);
                   temp.GetComponent<sc_direction>().my_z = new Vector3(0, 0, GameObject.Find("obj_bullet_spin_centa").transform.eulerAngles.z);
                temp.GetComponent<sc_direction>().cullent_my_z();
                    Destroy(temp, 2.5f);
                }
            }
          }
    }
