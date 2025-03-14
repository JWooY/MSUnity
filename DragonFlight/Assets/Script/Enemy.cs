using UnityEngine;

public class Enemy : MonoBehaviour
{
    //������ �ӵ��� ������ �ݴϴ�.
    public float moveSpeed = 6f;  

    void Start()
    {
        
    }


    void Update()
    {
        //������ �Ÿ��� ������ݴϴ�.
        float distanceY = moveSpeed * Time.deltaTime;

        //�������� �ݿ��մϴ�.
        transform.Translate(0, -distanceY, 0);

    }

    //ȭ�� ������ ���� ī�޶󿡼� ������ ������ ȣ��ȴ�.
    private void OnBecameInvisible()
    {
        //������Ʈ�� �����Ѵ�.
        Destroy(gameObject); //��ü�� �����Ѵ�.
    }



}
