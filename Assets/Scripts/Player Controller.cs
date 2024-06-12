using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //horizontal을 이용한 키보드입력 좌우
    //xRange를 이용한 최대 이동거리 -> 캐릭터가 화면 밖에 나가면 안되기때문
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    //gameObject
    public GameObject projectilePrefab;

    void Update()
    {
        //플레이어 x의 최대 최소 위치 xRange로 설정
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //horizontal을 사용해 (0~1) 값을 horizontalInput에 할당 -> 키보드 좌우 or a,d로 움직임
        horizontalInput = Input.GetAxis("Horizontal");
        //Vector3.right를 사용해 horizontalInput에 할당된값을 곱하여 움직임 설정
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //스페이스 사용시 instantiate를 사용해 무기 투척
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);    
        }
    }
}
