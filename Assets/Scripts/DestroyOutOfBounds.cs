using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //�ְ� ���� �� ��ġ
    private float topBound = 30;
    private float lowerBound = -10;

    void Update()
    {
        //�ְ�,�� �Ͻ� �ı� Debug�� ���� ���ӿ��� ���
        //�ְ� ������ �ı��� instantiate�� ���� ������Ʈ�� ���̱� ����
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
