using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    //해당 작업을 진행하기 위해서는 오브젝트에 Collider 컴포넌트가 추가 되어있어야 합니다.

    //유니티 마우스 , 터치 관련 이벤트 함수
    //1. OnMouseOver() : 해당 오브젝트에 마우스가 올라갈 경우 프레임마다 실행

    //2. OnMouseEnter() : 해당 오브젝트에 마우스가 올라갈 경우 1회 실행합니다.

    //3. OnMouseExit() : 해당 오브젝트에 마우스가 벗어날 때 1회 실행합니다.

    //4. OnMouseUp() : 해당 오브젝트에서 마우스 클릭이 해제될 때 실행

    //5. OnMouseDown() : 해당 오브젝트에서 마우스 클릭이 될 때 실행

    private void OnMouseOver()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);    
        }

    }

}
