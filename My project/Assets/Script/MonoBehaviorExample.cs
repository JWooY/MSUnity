using UnityEngine;

public class MonoBehaviorExample : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Start : 게임이 시작될 때 호출됩니다.");
    }


    void Update()
    {
        Debug.Log("Update : 프레임마다 호출됩니다.");

    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate : 물리 연산에 사용됩니다.");
    }

    //컨트롤 쉬프트 m 쓰면 이런거 유용하고 간편하게 만들 수 있음
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
    */

}
