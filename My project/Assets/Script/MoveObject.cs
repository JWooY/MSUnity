using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public float speed = 5.0f; // �̵� �ӵ� 


    void Update()
    {
        // Vector3 a = Vector3.right; // left, up, down, forward, back ��� �پ��� ������ �ִ�. �⺻������ 1�� ������

        //Ű �Է¿� ���� �̵�
        //float move = Input.GetAxis("Horizontal");
        //���� * ���ǵ� * Ÿ�ӵ�ŸŸ��(�����Ӹ��� �ӵ��� �����ϰ� �������)
        //transform.Translate(Vector3.right * move * speed * Time.deltaTime); // Ű����Ű ��~������ ������

        //�����̴� ��� ���ϱ�
        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0); // �����¿� 2D ������
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0 ,Input.GetAxis("Vertical")); // �յھ翷 3D ������

        //�����̴°� �ַ� �� �ΰ��߿� �ϳ��� ����.
        transform.position += move * speed * Time.deltaTime; // Ű����Ű�� ������
        transform.Translate(move * speed * Time.deltaTime);// Ű����Ű�� ������


    }
}
