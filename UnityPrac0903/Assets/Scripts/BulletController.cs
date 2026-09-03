using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // 앞으로 나가는 것
    // 일정 거리 날아가면 사라진다 or 일정 시간 지나면 사라짐
    [SerializeField] private float _speed = 3f;
    [SerializeField] private float _destroyTime = 3f;


    private void Awake()
    {
        Destroy(gameObject, _destroyTime);
    }


    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

}
