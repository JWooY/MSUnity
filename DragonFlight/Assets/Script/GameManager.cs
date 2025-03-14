using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //�̱���
    //��𿡼��� ������ �� �ֵ��� static(����)���� �ڱ��ڽ��� �����ؼ� �̱����̶�� ������������ ����غ���.

    public static GameManager instance; //�̱��� ����
    public Text scoreText;  //alt + enter�� using UnityEngine.UI; �߰�
                            //������ ǥ���ϴ� Text ��ü�� �����Ϳ��� �޾ƿ´�.
    public Text StartText; //���ӽ�����3,2,1

    int score = 0;  //������ ������ ����

    private void Awake()
    {
        if (instance == null)  //�̱����� ��������� (�������� �ڽ��� üũ�մϴ�. null����)
        {
            instance = this;    //�ڱ��ڽ��� �־��ش�.(�ڱ��ڽ��� �����Ѵ�.)
        }
    }

    void Start()
    {
        StartCoroutine(StartGame()); //���� ���� �ڷ�ƾ ����
    }

    IEnumerator StartGame()
    {

        int i = 3;
        while(i>0)
        {
            StartText.text = i.ToString();

            yield return new WaitForSeconds(1f);
            i--;

            if (i == 0)
            {
                StartText.gameObject.SetActive(false); //UI ���߱�
            }
        }
    }

    //ī��Ʈ�ٿ��� ������ ���� ����

    public void AddScore(int num)
    {
        score += num;   // ������ �����ش�.
        scoreText.text = "Score : " + score; // ������ ǥ���Ѵ�.
    }

}
