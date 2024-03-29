using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPattern01 : MonoBehaviour
{
    //부채꼴 모양 발사 기능
    public GameObject BulletPrefab; //총알 프리팹
    private void Start()
    {
        
    }
    private void Update()
    {
        FireSector();
    }
    int count = 0;
    private void FireSector()
    {
        var bullet = Instantiate(BulletPrefab); //총알 생성 진행  
        Rigidbody2D rbody = bullet.GetComponent<Rigidbody2D>();
        Vector2 dir = new Vector2(Mathf.Cos(Mathf.PI * count),-1);
        rbody.AddForce(dir.normalized * 3, ForceMode2D.Impulse);
        //normalized를 통해 정규화 진행
        //ForceMode2D.Impulse를 통해 순간적으로 힘을 가함.
        count++;
    }
}
