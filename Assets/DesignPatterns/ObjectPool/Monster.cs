using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    //�ش� �۾��� �����ϱ� ���ؼ��� ������Ʈ�� Collider ������Ʈ�� �߰� �Ǿ��־�� �մϴ�.

    //����Ƽ ���콺 , ��ġ ���� �̺�Ʈ �Լ�
    //1. OnMouseOver() : �ش� ������Ʈ�� ���콺�� �ö� ��� �����Ӹ��� ����

    //2. OnMouseEnter() : �ش� ������Ʈ�� ���콺�� �ö� ��� 1ȸ �����մϴ�.

    //3. OnMouseExit() : �ش� ������Ʈ�� ���콺�� ��� �� 1ȸ �����մϴ�.

    //4. OnMouseUp() : �ش� ������Ʈ���� ���콺 Ŭ���� ������ �� ����

    //5. OnMouseDown() : �ش� ������Ʈ���� ���콺 Ŭ���� �� �� ����

    private void OnMouseOver()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);    
        }

    }

}