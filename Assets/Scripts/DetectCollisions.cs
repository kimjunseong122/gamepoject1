using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    //�浹ó�� ontriggerenter���
    private void OnTriggerEnter(Collider other)
    {
        //�浹�� �浹 ������Ʈ, �ߵ����� ������Ʈ �ı�
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
