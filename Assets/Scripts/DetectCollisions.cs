using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    //충돌처리 ontriggerenter사용
    private void OnTriggerEnter(Collider other)
    {
        //충돌시 충돌 오브젝트, 중돌당한 오브젝트 파괴
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
