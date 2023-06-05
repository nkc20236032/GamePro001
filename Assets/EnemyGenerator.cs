using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    float span = 0.8f;
    float span2 = 0.5f;
    float delta = 0;
    float delta2 = 0;
    

    
    void Update()
    {
        this.delta += Time.deltaTime;
        this.delta2 += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(enemyPrefab);
            int px = Random.Range(-4, 5);
            go.transform.position = new Vector3(9.5f, px, 0);
        }
        if (this.delta2 > this.span2)
        {
            this.delta2 = 0;
            GameObject go = Instantiate(enemyPrefab);
            int px = Random.Range(-4, 5);
            go.transform.position = new Vector3(9.5f, px, 0);
        }

    }
}
