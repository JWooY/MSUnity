using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //���� ��������
    public GameObject enemy;
    public GameObject enemy2;

    //���� ���� �Լ�
    void SpawnEnemy()
    {
        // float randomX = Random.Range(-3.0f, 3.0f); // ���� ��Ÿ�� x��ǥ�� �������� �����ϱ�

        //���� ����
        //Instantiate(enemy, new Vector3(0f, transform.position.y, 0f), Quaternion.identity);
        //SpawnPoint���� ����
        //Instantiate(enemy, transform.position, Quaternion.identity);
        //10���� 7Ȯ����  SpawnPoint���� ����
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
        //SpawnEnemy, 1�� ����, 0.9f�ʸ��� ����
        //InvokeRepeating("SpawnEnemy", 1, 0.9f);

        StartCoroutine(WaitAndSpown()); // 3�� ��� �� ���� ����
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
