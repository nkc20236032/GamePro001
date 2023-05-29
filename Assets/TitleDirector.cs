using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetAxisRaw("Fire1")!= 0 )
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
