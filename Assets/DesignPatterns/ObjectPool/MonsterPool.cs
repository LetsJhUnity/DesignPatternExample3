using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPool : MonoBehaviour
{
    //[���� �������� ���]
    //1. Update ������ ����
    //2. Coroutine�� �̿��� ���� 
    public GameObject MonsterPrefab; //���� �����տ� ���� ��
    public int PoolSize; //Ǯ�� ������ ������ ����
    public float spawnTime; //������ ����(����) �ð�
    GameObject[] monsterPool; //���Ϳ� ���� �迭(���� Ǯ)

    GameObject monsterSpawnPool; //Ǯ�� ������ ������Ʈ
    void Start()
    {
        monsterSpawnPool = new GameObject("MonsterSpawnPool");

        //Ǯ���� ������ �����ŭ ������Ʈ�� �迭�� �Ҵ��մϴ�.
        monsterPool = new GameObject[PoolSize];
        //�Ҵ��� �迭��ŭ ������ �����մϴ�.
        Spawn(monsterPool, PoolSize);
        //Ư�� �ð����� ���Ͱ� ������ �� �ֵ��� �ڷ�ƾ�� �۵���Ű�ڽ��ϴ�.
        StartCoroutine("MonsterPooling");
    }
    private void Spawn(GameObject[] monsterPool, int poolSize)
    {
        for(int i = 0; i < poolSize; i++)
        {
            monsterPool[i] = Instantiate(MonsterPrefab); //���� ������ ����
            monsterPool[i].name = "Monster_" + i; //���� ���� �̸� �ֱ�
            monsterPool[i].transform.parent = monsterSpawnPool.transform; //Ǯ�� �θ�� ����մϴ�.
            //��Ȱ��ȭ ó��
            monsterPool[i].SetActive(false);
        }
    }

    IEnumerator MonsterPooling()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnTime);

            for(int i =0; i < PoolSize; i++)
            {
                //Ȱ��ȭ�� �Ǿ��ִ� ���¶�� �� �۾��� �ǳʶٰڽ��ϴ�.
                if (monsterPool[i].activeSelf == true)
                    continue;

                float x = Random.Range(-5, 5);
                float y = Random.Range(-5, 5); //3D�� ������ ¥�� ����� x , z������ �����մϴ�.

                monsterPool[i].transform.position = new Vector2(x, y);
                //3D�� ��쿡�� Vector3

                //Ȱ��ȭ �۾� ����
                monsterPool[i].SetActive(true);
                break;
            }
        }
    }


}
