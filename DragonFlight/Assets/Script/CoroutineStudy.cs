using System.Collections;
using UnityEngine;

public class CoroutineStudy : MonoBehaviour
{
    //C# ����Ƽ �ڷ�ƾ(Coroutine) ����
    //�ڷ�ƾ�� �Ϲ����� �Լ��� �޸� ������ ����ٰ� �ٽ� �̾ ������ �� �ִ� ����̴�.
    //�̸� �̿��ϸ� ���� �ð� �� ����ǰų�, Ư�� ������ ��ٸ��� ���� ����� ���� ���� �� �� �ִ�.
    void Start()
    {
        //StartCoroutine("ExampleCourutine"); // �̸��� �ᵵ �ǰ�
        StartCoroutine(ExampleCourutine()); // �Լ��� �ᵵ ��
    }

    IEnumerator ExampleCourutine()
    {
        while (true) // while ���� ����� �ݺ������ε� �������
        {
            Debug.Log("�ڷ�ƾ ����");
            yield return new WaitForSeconds(2f); // 2�� ���
            Debug.Log("2�� �� ����");
        }
    }
}
