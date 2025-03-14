using System.Collections;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet; // �̻��� ������ ������ ����
    public GameObject bullet_2; // �̻���lv.2

    void Start()
    {
        //InvokeRepeating("�Լ��̸�", 1(�ʱ������ð�), 1(������ �ð�); // 1�� �Ŀ� 1�� �������� Fire()�Լ��� ȣ���Ѵ�.
        //InvokeRepeating("Shoot", 0.5f, 0.2f); // ����Ϸ��� ����
        StartCoroutine(WaitAndShoot()); // 3�� ��� �� �߻�

    }

    void Shoot()
    {
        //�̻��� ������, ����������, ���Ⱚ ����
        Instantiate(bullet, transform.position, Quaternion.identity);
        SoundManager.instance.PlayBulletSound(); //�߻� ����

    }

    IEnumerator WaitAndShoot() // 3�� ����Ϸ��� ���� �Լ�
    {
        yield return new WaitForSeconds(3f);

        InvokeRepeating("Shoot", 0.5f, 0.2f);
    }


    void Update()
    {
        
    }
}
