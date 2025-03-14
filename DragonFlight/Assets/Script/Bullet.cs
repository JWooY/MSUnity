using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 10
        .0f;
    public GameObject exposion;


    void Start()
    {
        //Singleton.Instance.PrintMessage(); // Si gleton.cs에 있는 함수를 호출
    }


    void Update()
    {
        //y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        //미사일이 화면 밖으로 나가면 삭제한다.
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //미사일과 태그가 "Enemy"인 적과 부딪혔다.
        //if(collision.gameObject.tag == "Enemy") // 이것도 작동 되긴 함
        if (collision.gameObject.CompareTag("Enemy")) // 이게 안정적인 함수
        {
            //폭발 이펙트 생성
            Instantiate(exposion, transform.position, Quaternion.identity);
            //죽음 사운드
            SoundManager.instance.SoundDie(); //적 죽음 사운드
            //점수 올리기
            GameManager.instance.AddScore(10); //점수 올리기

            //적 지우기
            Destroy(collision.gameObject);
            //미사일 지우기
            Destroy(gameObject);

        }
        
    }

}
