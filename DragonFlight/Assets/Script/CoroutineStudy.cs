using System.Collections;
using UnityEngine;

public class CoroutineStudy : MonoBehaviour
{
    //C# 유니티 코루틴(Coroutine) 정리
    //코루틴은 일반적인 함수와 달리 실행을 멈췄다가 다시 이어서 실행할 수 있는 기능이다.
    //이를 이용하면 일정 시간 후 실행되거나, 특정 조건을 기다리는 등의 기능을 쉽게 구현 할 수 있다.
    void Start()
    {
        //StartCoroutine("ExampleCourutine"); // 이름을 써도 되고
        StartCoroutine(ExampleCourutine()); // 함수를 써도 됨
    }

    IEnumerator ExampleCourutine()
    {
        while (true) // while 덮어 씌우면 반복문으로도 만들어짐
        {
            Debug.Log("코루틴 시작");
            yield return new WaitForSeconds(2f); // 2초 대기
            Debug.Log("2초 후 실행");
        }
    }
}
