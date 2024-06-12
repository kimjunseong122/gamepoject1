using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //GameObject 배열에 animalPrefab입력
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Update is called once per frame

    void Start()
    {
        //invokeRepeating을 통해 시작시간 설정, 주기 설정
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        //랜덤길이 animalindex에 할당
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // x좌표 기준으로 랜덤으로 벡터설정후 spawnPos에 할당
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        //instantiate로 랜덤으로 animalPrefabs배열중 프리팹 생성과 랜덤 위치에서 생성
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
