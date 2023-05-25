using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(-0.02f, 0, 0);

        if (transform.position.x < -9.5f)
        {
            Destroy(gameObject);
        }
    }
}
