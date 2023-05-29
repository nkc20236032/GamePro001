using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // x�������̈ړ��͈͂̍ŏ��l
    [SerializeField] private float _minX = -8.5f;

    // x�������̈ړ��͈͂̍ő�l
    [SerializeField] private float _maxX = 8.5f;

    // y�������̈ړ��͈͂̍ŏ��l
    [SerializeField] private float _minY = -4.6f;

    // y�������̈ړ��͈͂̍ő�l
    [SerializeField] private float _maxY = 4.6f;

    Animator animator;


    void Start()
    {
        this.animator = GetComponent<Animator>();
    }


    void Update()
    {
        var pos = transform.position;

        // x�������̈ړ��͈͐���
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);

        // y�������̈ړ��͈͐���
        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);


        transform.position = pos;


        Vector3 dir = Vector3.zero;
        float speed = 7;

        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        if (dir.y == 0)
        {
            this.animator.SetTrigger("DefaultTrigger");
        }
        if (dir.y > 0)
        {
            this.animator.SetTrigger("UpTrigger");
        }
        if (dir.y < 0)
        {
            this.animator.SetTrigger("DownTrigger");
        }

        transform.position += dir.normalized * speed * Time.deltaTime;
    }
}
