using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public static bool canMove = false;

    void Start()
    {
        StartCoroutine(Wait());
    }


    void FixedUpdate()
    {
        if (canMove == true)
        {
            moveControl();
        }
    }

    public void moveControl()
    {
        //지정한 Axis를 통해 키의 방향을 판단하고 속도와 프레임 판정을 곱해 이동량을 정한다.
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //이동량만큼 실제로 이동을 해주는 함수
        transform.Translate(distanceX, 0, 0);
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("3초 뒤에 실행");
        canMove = true;
    }
}
