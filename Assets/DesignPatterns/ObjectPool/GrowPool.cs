using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowPool : MonoBehaviour
{
    public GameObject seedPrefab;
    public int PoolSize = 3;
    GameObject[] seedPool;

    GameObject seedSpawnPool; //Ǯ�� ������ ������Ʈ
    void Start()
    {
        seedSpawnPool = new GameObject("MonsterSpawnPool");

        //Ǯ���� ������ �����ŭ ������Ʈ�� �迭�� �Ҵ��մϴ�.
        seedPool = new GameObject[PoolSize];
        //�Ҵ��� �迭��ŭ ������ �����մϴ�.
        Spawn(seedPool, PoolSize);
    }
    private void Spawn(GameObject[] Pool, int poolSize)
    {
        for (int i = 0; i < poolSize; i++)
        {
            Pool[i] = Instantiate(seedPrefab);
            Pool[i].name = "seed_" + i; 
            Pool[i].transform.parent = seedSpawnPool.transform; 
            //��Ȱ��ȭ ó��
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
                    //Ȱ��ȭ�� �Ǿ��ִ� ���¶�� �� �۾��� �ǳʶٰڽ��ϴ�.
                    if (seedPool[i].activeSelf == true)
                        continue;
                    seedPool[i].transform.position = transform.position;
                    //3D�� ��쿡�� Vector3
                    //Ȱ��ȭ �۾� ����
                    seedPool[i].SetActive(true);
                    break;
                }
            }
        }
    }
}
