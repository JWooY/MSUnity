using UnityEngine;

public class FunctionExample : MonoBehaviour
{

    void SayHello()
    {
        Debug.Log("Hello, Unity");
    }

    int AddNumbers(int a, int b)
    {
        return a + b;
    }


    void Start()
    {
        SayHello(); //함수 호출
        int total = AddNumbers(3, 5);
        Debug.Log("Total = " + total); // 당연히 ($" { } "); 형식도 사용 가능
    }

    void Update()
    {
        
    }
}
