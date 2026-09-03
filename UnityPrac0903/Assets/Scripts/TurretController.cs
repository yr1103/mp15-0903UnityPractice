using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _detectionRange;

    [SerializeField] private Transform _muzzleTransform;
    [SerializeField] private GameObject _bulletPrefab;


    private void Update()
    {
        // 충돌처리 배우면 더 간단하게 가능하다
        // 포탑이랑 플레이어 거리 구하고
        float distance = Vector3.Distance(transform.position, _playerTransform.position);
        
        // 감지 거리 안으로 들어오면 플레이어 응시&격발
        if (distance <= _detectionRange)
        {            
            LookAtPlayer();
            SpawnBullet();
        }    
        else
        {
            RotateTurret();
        }
    }
    
    private void SpawnBullet()
    {

        // z쿨타임 텔타타임으로 

        GameObject bullet = Instantiate(_bulletPrefab);
        bullet.transform.position = _muzzleTransform.position;
        bullet.transform.rotation = _muzzleTransform.rotation;
    }

    private void RotateTurret()
    {
        transform.Rotate(Vector3.up, _rotateSpeed * Time.deltaTime);
    }

    public void LookAtPlayer()
    {
        transform.LookAt(_playerTransform);
    }
}



    // 총 소리

    // (플레이어가 특정 거리 밖에 있을 땐 빙글빙글 돈다)
    // (일정거리 내에 있을 때는 플레이어 응시한다)
    // 총알 소환
    // 총구 위치에