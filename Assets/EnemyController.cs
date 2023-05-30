using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject player;
    
    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    
    void Update()
    {
        //�ړ�
        transform.Translate(-0.05f, 0, 0);
        //��ʊO
        if (transform.position.x < -9.5f)
        {
            Destroy(gameObject);
        }

        //�����蔻��
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float rEn = 0.6f;
        float rPl = 0.3f;

        if (d < rEn + rPl)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseTime();

            Destroy(gameObject);
        }
    }
}
