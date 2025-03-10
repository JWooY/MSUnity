using Unity.VisualScripting;
using UnityEngine;

public class ConditionExample : MonoBehaviour
{
    //연산자와 조건문
    public int health = 100;



    void Update()
    {
        health -= 1; // 체력 1씩 계속 감소될것.
        Debug.Log("체력 : " + health);

        //조건문
        if (health <= 0)
        {
            Debug.Log("캐릭터가 죽었습니다.");
            
        }
    }
}
