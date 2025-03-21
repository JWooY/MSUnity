using UnityEngine;

public class VectorStudy : MonoBehaviour
{
    /*
    public Vector2 v2 = new Vector2(10,10); // x,y 좌표다.
    public Vector3 v3 = new Vector3(1, 1, 1); // x,y,z 좌표다.
    public Vector4 v4 = new Vector4(1.0f, 0.5f, 0.0f, 1.0f); // 4차원 벡터다. RGB값이나 색상값 같은걸 쓰려고할때 많이들쓴다.
    */

    void Start()
    {
        //벡터의 더하기
        /*
        Vector3 a = new Vector3(1, 0, 0);
        Vector3 b = new Vector3(2, 0, 0);
        Vector3 c = a + b;

        Debug.Log("Vector" + c);
        */

        //벡터의 더하기2
        /*
        Vector3 a = new Vector3(1, 1, 0);
        Vector3 b = new Vector3(2, 0, 0);
        Vector3 c = a + b;

        Debug.Log("Vector" + c);
        
        Debug.Log("길이 : "+c.magnitude); // magnitude는 벡터의 길이를 반환한다.
        */

        //정규화 normalize
        //벡터의 크기를 1로 만들고 방향만 유지
        Vector3 a = new Vector3(3, 0, 0);
        Vector3 normalizedVector = a.normalized;
        Debug.Log("1의 길이 방향만 설정하는 정규화 벡터 : " + normalizedVector);


    }


    void Update()
    {
        
    }
}
