using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [NonSerialized]
    public BulletPool BulletPool; //BulletPool에 다시 등록되기 위함
    
    public enum BULLETDIR
    {
        NONE,
        LEFT,
        RIGHT
    }

    [HideInInspector]
    public BULLETDIR dir = BULLETDIR.NONE;

    //총알 속도
    private float speed = 270f;

    private float lifeCycle;
    
    private void Update()
    {
        MoveMent();
        UpdateLifeCycle();
    }

    //Bullet Move
    private void MoveMent()
    {
        var move = dir == BULLETDIR.LEFT ? Vector2.left * speed : Vector2.right * speed;
        transform.Translate(move * Time.deltaTime);
    }

    //Bullet LifeCycle
    private void UpdateLifeCycle()
    {
        lifeCycle += Time.deltaTime;
        if (lifeCycle > 1.5f)
        {
            lifeCycle = 0f;
            dir= BULLETDIR.LEFT;
            gameObject.SetActive(false);
            BulletPool.BulletAdd(this);
            transform.parent = BulletPool.transform;
        }  
    }
}
