using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 10
        .0f;
    public GameObject exposion;


    void Start()
    {
        //Singleton.Instance.PrintMessage(); // Si gleton.cs�� �ִ� �Լ��� ȣ��
    }


    void Update()
    {
        //y�� �̵�
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        //�̻����� ȭ�� ������ ������ �����Ѵ�.
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�̻��ϰ� �±װ� "Enemy"�� ���� �ε�����.
        //if(collision.gameObject.tag == "Enemy") // �̰͵� �۵� �Ǳ� ��
        if (collision.gameObject.CompareTag("Enemy")) // �̰� �������� �Լ�
        {
            //���� ����Ʈ ����
            Instantiate(exposion, transform.position, Quaternion.identity);
            //���� ����
            SoundManager.instance.SoundDie(); //�� ���� ����
            //���� �ø���
            GameManager.instance.AddScore(10); //���� �ø���

            //�� �����
            Destroy(collision.gameObject);
            //�̻��� �����
            Destroy(gameObject);

        }
        
    }

}
