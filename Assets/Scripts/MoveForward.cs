using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    // Update is called once per frame
    void Update()
    {
        //vector3.forward로 앞을 향하게 설정
        transform.Translate(Vector3.forward * Time.deltaTime * speed);


    }
}
