using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AttackPattern02 : MonoBehaviour
{
    public GameObject BulletPrefab;


    private void Start()
    {
       Pattern02();
    }

    void Pattern02()
    {
        //원으로 펼쳐줄 탄알 갯수만큼 반복을 진행합니다.
        for (int i = 0; i < 50; i++)
        {
            var bullet = Instantiate(BulletPrefab);
            bullet.transform.position = transform.position;
            bullet.transform.rotation = Quaternion.identity;
            Rigidbody2D rbody = bullet.GetComponent<Rigidbody2D>();
            //원 운동을 위한 방향 값 계산
            //x 좌표, y 좌표에 대한 값을 계산하고 x -> Cos , y -> Sin
            Vector2 direction = new Vector2(Mathf.Cos(Mathf.PI * 2 * i / 50), Mathf.Sin(Mathf.PI * 2 * i / 50));
            rbody.AddForce(direction.normalized * 2.0f, ForceMode2D.Impulse);
            //문제) AddForce로 힘을 가하나, 발사 각도에 따라 회전 값 적용이 안되서 각도는 다른데 힘이 가해지는 위치가 같아
            //같은 방향으로 이동되는 현상이 발생
            Vector3 rotation = (Vector3.forward * 360 * i / 50) + Vector3.forward * 90;//(보정값)
            bullet.transform.Rotate(rotation);  
        }
    }
}
