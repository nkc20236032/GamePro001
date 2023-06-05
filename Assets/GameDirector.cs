using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject timeGauge;
    GameObject metersText;
    GameObject scoreText;
    float s = 0.6f;
    float delta = 0;
    float m = 0;
    public static int score = 0;


    void Start()
    {
        Application.targetFrameRate = 60;

        this.timeGauge = GameObject.Find("TimeGauge");
        this.metersText = GameObject.Find("meters");
        this.scoreText = GameObject.Find("score");
    }

    
    void Update()
    {
        // ŽžŠÔŒo‰ß
        this.delta += 0.1f;
        if (this.delta >= this.s)
        {
            this.delta = 0;
            this.timeGauge.GetComponent<Image>().fillAmount -= 0.001f;
        }

        m += 1.0f;
        this.metersText.GetComponent<TextMeshProUGUI>().text = this.m.ToString("F0") + "m";

        if (this.timeGauge.GetComponent<Image>().fillAmount == 0)
        {
            SceneManager.LoadScene("ClearScene");

        }

        this.scoreText.GetComponent<TextMeshProUGUI>().text = "score " + score.ToString();

    }

    public void DecreaseTime()
    {
        this.timeGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void Score()
    {
        score += 10;
    }

    public static int Result()
    {
        return score;
    }
}
