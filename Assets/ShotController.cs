using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    float speed = 10.0f;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);

        if (transform.position.x >= 9.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject director = GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().Score();

        Destroy(col.gameObject);
        Destroy(gameObject);
    }
}
