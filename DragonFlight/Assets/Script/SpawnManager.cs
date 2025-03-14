using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //몬스터 가져오기
    public GameObject enemy;
    public GameObject enemy2;

    //몬스터 생성 함수
    void SpawnEnemy()
    {
        // float randomX = Random.Range(-3.0f, 3.0f); // 적이 나타날 x좌표를 랜덤으로 생성하기

        //몬스터 생성
        //Instantiate(enemy, new Vector3(0f, transform.position.y, 0f), Quaternion.identity);
        //SpawnPoint에서 생성
        //Instantiate(enemy, transform.position, Quaternion.identity);
        //10분의 7확률로  SpawnPoint에서 생성
        float random = Random.Range(0, 10);
        if (random < 7)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(enemy2, transform.position, Quaternion.identity);
        }

    }

    void Start()
    {
        //SpawnEnemy, 1초 쉬고, 0.9f초마다 생성
        //InvokeRepeating("SpawnEnemy", 1, 0.9f);

        StartCoroutine(WaitAndSpown()); // 3초 대기 후 몬스터 생성
    }
    
    IEnumerator WaitAndSpown()
    {
        yield return new WaitForSeconds(3f);
        InvokeRepeating("SpawnEnemy", 1, 1.7f);
    }


    void Update()
    {
        
    }
}
