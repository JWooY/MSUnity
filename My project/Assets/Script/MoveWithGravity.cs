using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{
    public Rigidbody rb;

    public float jumpForce = 5.0f; //���� ��

    void Start()
    {
        
    }


    void Update()
    {
        //spzceŰ�� ������ ����
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Rigidbody: ����ȿ���� �߰��� �߷��� �ۿ��մϴ�.
            //AddForce: ������ ���� ������Ʈ�� ���� ���մϴ�.
            //ForceMode.Impulse: ���������� ���� ���մϴ�.
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }
}
