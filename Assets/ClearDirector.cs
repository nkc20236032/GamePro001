using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    GameObject resultText;
    int score;
    
    void Start()
    {
        score = GameDirector.Result();
        resultText = GameObject.Find("Result");

    }

    
    void Update()
    {
        resultText.GetComponent<TextMeshProUGUI>().text = "score " + score.ToString();
        if(Input.GetAxisRaw("Fire1") != 0)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
