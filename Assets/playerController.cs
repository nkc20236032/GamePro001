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

    [SerializeField] private GameObject shot; 
    [SerializeField] private Transform shotPoint;

    [SerializeField] private float shotTime = 0.2f; //�U���̊Ԋu
    private float currentshotTime; //�U���̊Ԋu���Ǘ�
    private bool canshot; //�U���\��Ԃ����w�肷��t���O

    void Start()
    {
        this.animator = GetComponent<Animator>();

        currentshotTime = shotTime;
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

        Shot();
    }

    void Shot()
    {
        shotTime += Time.deltaTime;

        if (shotTime > currentshotTime)
        {
            canshot = true;
        }

        if (Input.GetAxisRaw("Fire1") == 1)
        {
            if (canshot)
            {
                Instantiate(shot, shotPoint.position, transform.rotation);
                canshot = false;
                shotTime = 0;
            }
        }
    }
}
