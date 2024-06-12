using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //horizontal�� �̿��� Ű�����Է� �¿�
    //xRange�� �̿��� �ִ� �̵��Ÿ� -> ĳ���Ͱ� ȭ�� �ۿ� ������ �ȵǱ⶧��
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    //gameObject
    public GameObject projectilePrefab;

    void Update()
    {
        //�÷��̾� x�� �ִ� �ּ� ��ġ xRange�� ����
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //horizontal�� ����� (0~1) ���� horizontalInput�� �Ҵ� -> Ű���� �¿� or a,d�� ������
        horizontalInput = Input.GetAxis("Horizontal");
        //Vector3.right�� ����� horizontalInput�� �Ҵ�Ȱ��� ���Ͽ� ������ ����
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //�����̽� ���� instantiate�� ����� ���� ��ô
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);    
        }
    }
}
