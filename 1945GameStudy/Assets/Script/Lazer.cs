using UnityEngine;

public class Lazer : MonoBehaviour
{
    public GameObject effect;
    Transform pos; // �÷��̾� �̵���
    int Attack = 10; // ������ ������

    void Start()
    {
        pos = GameObject.Find("Player").GetComponent<Player>().pos; //�÷��̾� ������Ʈ�� ã�Ƽ� �÷��̾��� �̵����� ������. Find���� Tag�� �� ������ �ϴ� �ẽ
    }


    void Update()
    {
        transform.position = pos.position; // �������� ��ġ�� �÷��̾��� ��ġ�� �̵�
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster")) // ���� �浹��
        {
            collision.gameObject.GetComponent<Monster>().Damage(Attack++); // ���� �������� ��

            CreateEffect(collision.transform.position);
        }

        if (collision.CompareTag("Boss")) // ������ �浹��
        {
            //collision.gameObject.GetComponent<Boss>().Damage(Attack++); // ������ �������� ��

            CreateEffect(collision.transform.position);

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster")) // ���� �浹��
        {
            collision.gameObject.GetComponent<Monster>().Damage(Attack++); // ���� �������� ��

            CreateEffect(collision.transform.position);
        }

        if (collision.CompareTag("Boss")) // ������ �浹��
        {
            //collision.gameObject.GetComponent<Boss>().Damage(Attack++); // ������ �������� ��

            CreateEffect(collision.transform.position);

        }
    }

    void CreateEffect(Vector3 position) // ����Ʈ ���� �Լ�ȭ
    {
        GameObject go = Instantiate(effect, position, Quaternion.identity); // ����Ʈ ����
        Destroy(go, 1); // 1�ʵ� ����Ʈ ����
    }

}
