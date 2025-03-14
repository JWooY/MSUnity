using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //싱글톤
    //어디에서나 접근할 수 있도록 static(정적)으로 자기자신을 저장해서 싱글톤이라는 디자인패턴을 사용해본다.

    public static GameManager instance; //싱글톤 선언
    public Text scoreText;  //alt + enter로 using UnityEngine.UI; 추가
                            //점수를 표시하는 Text 객체를 에디터에서 받아온다.
    public Text StartText; //게임시작전3,2,1

    int score = 0;  //점수를 저장할 변수

    private void Awake()
    {
        if (instance == null)  //싱글톤이 비어있으면 (정적으로 자신을 체크합니다. null인지)
        {
            instance = this;    //자기자신을 넣어준다.(자기자신을 저장한다.)
        }
    }

    void Start()
    {
        StartCoroutine(StartGame()); //게임 시작 코루틴 실행
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
                StartText.gameObject.SetActive(false); //UI 감추기
            }
        }
    }

    //카운트다운이 끝나면 게임 시작

    public void AddScore(int num)
    {
        score += num;   // 점수를 더해준다.
        scoreText.text = "Score : " + score; // 점수를 표시한다.
    }

}
