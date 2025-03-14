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
        //������ Axis�� ���� Ű�� ������ �Ǵ��ϰ� �ӵ��� ������ ������ ���� �̵����� ���Ѵ�.
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //�̵�����ŭ ������ �̵��� ���ִ� �Լ�
        transform.Translate(distanceX, 0, 0);
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("3�� �ڿ� ����");
        canMove = true;
    }
}
