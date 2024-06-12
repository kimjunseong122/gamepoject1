using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //최고 최저 적 위치
    private float topBound = 30;
    private float lowerBound = -10;

    void Update()
    {
        //최고,저 일시 파괴 Debug를 통해 게임오버 출력
        //최고 최저시 파괴는 instantiate로 인한 오브젝트가 쌓이기 때문
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
