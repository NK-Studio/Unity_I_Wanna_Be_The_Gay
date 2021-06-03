using System;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    [SerializeField]
    private List<bullet> bullets; //Bullet컴포넌트를 가져옴

    public Transform BulletPos;
    
    private void Awake()
    {
        //총알에게 오브젝트 풀을 참조 시킴
        foreach (var bullet in bullets)
            bullet.BulletPool = this;
    }

    /// <summary>
    /// 총을 쏩니다.
    /// </summary>
    /// <param name="horizontal"></param>
    public void Shot(float horizontal)
    {
        // audio.PlayOneShot(world.instance.audio_effect[8]);

        //등록되어있는 총알의 개수가 1개 이상이면 0번째 Index를 반환하고, 총알이 없을시 -1을 반환
        int id = bullets.Count > 0 ? 0 : -1;

        //총알이 없을시 리턴
        if (id == -1) return;

        bullets[id].gameObject.SetActive(true);
        bullets[id].transform.parent = null;
        bullets[id].transform.position = BulletPos.position;
        bullets[id].dir = Mathf.Approximately(horizontal, -1) ? bullet.BULLETDIR.LEFT : bullet.BULLETDIR.RIGHT;
        bullets.RemoveAt(id);
    }

    /// <summary>
    /// 리스트에 총알을 재등록합니다.
    /// </summary>
    /// <param name="bullet"></param>
    public void BulletAdd(bullet bullet)
        => bullets.Add(bullet);
}
