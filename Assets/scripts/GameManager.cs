using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject rain;
    public GameObject endPanel;

    public Text totalScoreTxt;
    public Text timeTxt;

    int totalScore;

    float totalTime = 30.0f;

    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1.0f;
    }

    void Start()
    {
        InvokeRepeating("MakeRain",0f,0.5f); // 함수 반복실행 기능 < 인보크리피팅
    }

    void Update()
    {
        
        if (totalTime > 0f)
        {
            totalTime -= Time.deltaTime;
        }

        else
        {
            totalTime = 0f;
            endPanel.SetActive(true);
            Time.timeScale = 0f;
        }

        timeTxt.text = totalTime.ToString("N1");

  
    }

    

    void MakeRain()
    {
        Instantiate(rain);
    }

    public void AddScore(int score)
    {
        totalScore += score;
        totalScoreTxt.text = totalScore.ToString();
        //Debug.Log(totalScore);
    }

}
