using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowPool : MonoBehaviour
{
    public GameObject seedPrefab;
    public int PoolSize = 3;
    GameObject[] seedPool;

    GameObject seedSpawnPool; //풀을 관리할 오브젝트
    void Start()
    {
        seedSpawnPool = new GameObject("MonsterSpawnPool");

        //풀에서 설정된 사이즈만큼 오브젝트를 배열에 할당합니다.
        seedPool = new GameObject[PoolSize];
        //할당한 배열만큼 생성을 진행합니다.
        Spawn(seedPool, PoolSize);
    }
    private void Spawn(GameObject[] Pool, int poolSize)
    {
        for (int i = 0; i < poolSize; i++)
        {
            Pool[i] = Instantiate(seedPrefab);
            Pool[i].name = "seed_" + i; 
            Pool[i].transform.parent = seedSpawnPool.transform; 
            //비활성화 처리
            Pool[i].SetActive(false);
        }
    }

    void Init(int index)
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "able")
        {
            
            if(Input.GetKeyDown(KeyCode.Space))
            {
                for (int i = 0; i < PoolSize; i++)
                {
                    //활성화가 되어있는 상태라면 이 작업은 건너뛰겠습니다.
                    if (seedPool[i].activeSelf == true)
                        continue;
                    seedPool[i].transform.position = transform.position;
                    //3D일 경우에는 Vector3
                    //활성화 작업 진행
                    seedPool[i].SetActive(true);
                    break;
                }
            }
        }
    }
}
