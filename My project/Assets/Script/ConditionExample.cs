using Unity.VisualScripting;
using UnityEngine;

public class ConditionExample : MonoBehaviour
{
    //�����ڿ� ���ǹ�
    public int health = 100;



    void Update()
    {
        health -= 1; // ü�� 1�� ��� ���ҵɰ�.
        Debug.Log("ü�� : " + health);

        //���ǹ�
        if (health <= 0)
        {
            Debug.Log("ĳ���Ͱ� �׾����ϴ�.");
            
        }
    }
}
