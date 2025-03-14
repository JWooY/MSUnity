using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //싱글톤
    public static SoundManager instance; // 자기자신을 변수로 담기]

    AudioSource myAudio; // 오디오 소스 컴포넌트를 담을 변수
    public AudioClip SoundBullet; // 재생할소리
    public AudioClip soundDie; // 죽는사운드

    private void Awake()
    {
        if (SoundManager.instance == null) // 인스턴스 있는지 검사
        {
            SoundManager.instance = this; // 자기자신을 인스턴스로 만들기
        }
        else
        {
            Destroy(this.gameObject); // 인스턴스가 있으면 자기자신을 파괴하기
        }
    }
    void Start()
    {
        myAudio = GetComponent<AudioSource>(); // 오디오 소스 컴포넌트를 가져오기
    }

    public void PlayBulletSound()
    {
        myAudio.PlayOneShot(SoundBullet); // 미사일 사운드 실행
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie); // 몬스터 죽음 사운드
    }
        

    
}