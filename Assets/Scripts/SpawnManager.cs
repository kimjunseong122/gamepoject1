using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //GameObject �迭�� animalPrefab�Է�
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Update is called once per frame

    void Start()
    {
        //invokeRepeating�� ���� ���۽ð� ����, �ֱ� ����
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        //�������� animalindex�� �Ҵ�
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // x��ǥ �������� �������� ���ͼ����� spawnPos�� �Ҵ�
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        //instantiate�� �������� animalPrefabs�迭�� ������ ������ ���� ��ġ���� ����
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
