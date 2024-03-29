using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Detector))] //디텍터 타입을 대상으로 연결
public class DetectFront : Editor
{
    //GUI 환경에서 처리될 기능을 작성하는 위치
    private void OnSceneGUI()
    {
        //타겟을 디텍터로 잡습니다.
        Detector detector = (Detector)target;

        Handles.color = Color.red;
        //핸들의 색을 red로 변경합니다.

        Handles.DrawLine(detector.transform.position, detector.transform.forward * 2.0f, 3.0f);

        //핸들을 통해 디텍터의 위치부터 앞 방향으로 2만큼 선을 그리겠습니다.
        //굵기는 3입니다.

        Handles.color = Color.green;
        //핸들의 색을 초록색으로 변경하는 작업
        Handles.DrawLine(Vector3.zero, (AngleDirection(detector.angle) * 0.5f ) * detector.radius); //오른쪽
        Handles.DrawLine(Vector3.zero, (AngleDirection(detector.angle) * -1 * 0.5f) * detector.radius); //왼쪽
    }
    Vector3 AngleDirection(float angle) => new Vector3(Mathf.Sin(angle * Mathf.Deg2Rad), 0, Mathf.Cos(angle * Mathf.Deg2Rad));
}
