using UnityEngine;

public class Lazer : MonoBehaviour
{
    public GameObject effect;
    Transform pos; // 플레이어 이동값
    int Attack = 10; // 레이저 데미지

    void Start()
    {
        pos = GameObject.Find("Player").GetComponent<Player>().pos; //플레이어 오브젝트를 찾아서 플레이어의 이동값을 가져옴. Find보다 Tag가 더 낫지만 일단 써봄
    }


    void Update()
    {
        transform.position = pos.position; // 레이저의 위치를 플레이어의 위치로 이동
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster")) // 적과 충돌시
        {
            collision.gameObject.GetComponent<Monster>().Damage(Attack++); // 적의 데미지를 줌

            CreateEffect(collision.transform.position);
        }

        if (collision.CompareTag("Boss")) // 보스와 충돌시
        {
            //collision.gameObject.GetComponent<Boss>().Damage(Attack++); // 보스의 데미지를 줌

            CreateEffect(collision.transform.position);

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster")) // 적과 충돌시
        {
            collision.gameObject.GetComponent<Monster>().Damage(Attack++); // 적의 데미지를 줌

            CreateEffect(collision.transform.position);
        }

        if (collision.CompareTag("Boss")) // 보스와 충돌시
        {
            //collision.gameObject.GetComponent<Boss>().Damage(Attack++); // 보스의 데미지를 줌

            CreateEffect(collision.transform.position);

        }
    }

    void CreateEffect(Vector3 position) // 이펙트 생성 함수화
    {
        GameObject go = Instantiate(effect, position, Quaternion.identity); // 이펙트 생성
        Destroy(go, 1); // 1초뒤 이펙트 삭제
    }

}
