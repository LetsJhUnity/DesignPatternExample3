using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathPendulum : MonoBehaviour
{
    public float angle; //���� ǥ��

    private float time = 0; //�ð�
    private float speed  = 2.0f;//�ӵ�

    private void Update()
    {
        time += Time.deltaTime * speed;
        transform.rotation = MovePendulum();
        //������ ������ z���� 1���� -1���� �̵��ϴ� �۾��� �ݺ��� ���Դϴ�.
    }

    //-91 ~ 91
    //0.5

    //-90 ~ 90
    // 0.5

    //���� ��� ���� �Լ� ����
    Quaternion MovePendulum() => Quaternion.Lerp(Quaternion.Euler(Vector3.forward * angle)
        , Quaternion.Euler(Vector3.back * angle), LerpT());

    //���Ϸ� ��(Euler)
    //Transform ������Ʈ�� Rotation ���� �� ���� ����(Degree)�� �����Ǿ� �ֽ��ϴ�.
    //3���� �࿡ ���� ȸ�� ������ ǥ���� ���� ���Ϸ� ���̶�� �����մϴ�.
    //�� ���Ϸ� ���� ���� ��ġ�� ��Ȳ���� ���� 3���� �ƴ� 2������ ���� ���ɼ��� �����մϴ�.(���� �� ����)
    //z -> x -> z ������ ���Ϸ� ���� ó���ϰ��� �մϴ�.
    // �� ����� ������ ������ �������� ���� ���ø� �˴ϴ�.
    //Rx  =   1    0    0
    //        0   cos   -sin
    //        0   sin   cos
    //Rz  =   cos  -sin  0
    //        sin   cos  0
    //         0     0   1
    //RzRxRz= cos  -sin  0     1    0    0       cos -sin 0
    //        sin   cos  0     0    cos  -sin    sin  cos 0
    //         0     0   1     0    sin   cos     0    0  1
    //���Ϸ� ���� ���� a,b,c��� �����մϴ�.
    //      cos(a+c)  -sin(a+c)  0
    //      sin(a+c)  cos(a+c)   0
    //         0        0        1
    //�� �̵��� �����ϸ鼭 ��ġ�� ������ �߻��ϰ� �˴ϴ�.
    //Lerp(a,b,t) �Լ��� t�� ���� ����ϴ� �Լ��Դϴ�.
    //Lerp�� a �������� b �������� �ε巴�� �̵��ϸ� t �������� �̵��ϰ� �˴ϴ�.
    float LerpT() => (Mathf.Sin(time) + 1) * 0.5f;
}
