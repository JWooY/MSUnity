using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //�̱���
    public static SoundManager instance; // �ڱ��ڽ��� ������ ���]

    AudioSource myAudio; // ����� �ҽ� ������Ʈ�� ���� ����
    public AudioClip SoundBullet; // ����ҼҸ�
    public AudioClip soundDie; // �״»���

    private void Awake()
    {
        if (SoundManager.instance == null) // �ν��Ͻ� �ִ��� �˻�
        {
            SoundManager.instance = this; // �ڱ��ڽ��� �ν��Ͻ��� �����
        }
        else
        {
            Destroy(this.gameObject); // �ν��Ͻ��� ������ �ڱ��ڽ��� �ı��ϱ�
        }
    }
    void Start()
    {
        myAudio = GetComponent<AudioSource>(); // ����� �ҽ� ������Ʈ�� ��������
    }

    public void PlayBulletSound()
    {
        myAudio.PlayOneShot(SoundBullet); // �̻��� ���� ����
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie); // ���� ���� ����
    }
        

    
}