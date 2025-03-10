using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public float speed = 5.0f; // 이동 속도 


    void Update()
    {
        // Vector3 a = Vector3.right; // left, up, down, forward, back 등등 다양한 방향이 있다. 기본적으로 1로 설정됨

        //키 입력에 따라 이동
        //float move = Input.GetAxis("Horizontal");
        //방향 * 스피드 * 타임델타타임(프레임마다 속도를 일정하게 만들어줌)
        //transform.Translate(Vector3.right * move * speed * Time.deltaTime); // 키보드키 오~왼으로 움직임

        //움직이는 방법 정하기
        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0); // 상하좌우 2D 움직임
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0 ,Input.GetAxis("Vertical")); // 앞뒤양옆 3D 움직임

        //움직이는건 주로 이 두개중에 하나를 쓴다.
        transform.position += move * speed * Time.deltaTime; // 키보드키로 움직임
        transform.Translate(move * speed * Time.deltaTime);// 키보드키로 움직임


    }
}
