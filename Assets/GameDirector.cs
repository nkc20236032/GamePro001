using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject timeGauge;
    GameObject metersText;
    float s = 0.1f;
    float delta = 0;
    float m = 0;
    
    void Start()
    {
        this.timeGauge = GameObject.Find("TimeGauge");
        this.metersText = GameObject.Find("meters");
    }

    
    void Update()
    {
        // ŽžŠÔŒo‰ß
        this.delta += Time.deltaTime;
        if (this.delta > this.s)
        {
            this.delta = 0;
            this.timeGauge.GetComponent<Image>().fillAmount -= 0.001f;
        }

        m += 0.1f;
        this.metersText.GetComponent<TextMeshProUGUI>().text = this.m.ToString("F0") + "m";

    }

    public void DecreaseTime()
    {
        this.timeGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
