using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    // Update is called once per frame
    void Update()
    {
        //vector3.forward�� ���� ���ϰ� ����
        transform.Translate(Vector3.forward * Time.deltaTime * speed);


    }
}
