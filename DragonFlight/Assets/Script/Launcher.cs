using System.Collections;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet; // 미사일 프리팹 가져올 변수
    public GameObject bullet_2; // 미사일lv.2

    void Start()
    {
        //InvokeRepeating("함수이름", 1(초기지연시간), 1(지연할 시간); // 1초 후에 1초 간격으로 Fire()함수를 호출한다.
        //InvokeRepeating("Shoot", 0.5f, 0.2f); // 대기하려고 수정
        StartCoroutine(WaitAndShoot()); // 3초 대기 후 발사

    }

    void Shoot()
    {
        //미사일 프리팹, 런쳐포지션, 방향값 안줌
        Instantiate(bullet, transform.position, Quaternion.identity);
        SoundManager.instance.PlayBulletSound(); //발사 사운드

    }

    IEnumerator WaitAndShoot() // 3초 대기하려고 만든 함수
    {
        yield return new WaitForSeconds(3f);

        InvokeRepeating("Shoot", 0.5f, 0.2f);
    }


    void Update()
    {
        
    }
}
