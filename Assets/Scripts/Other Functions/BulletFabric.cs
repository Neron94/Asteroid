using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroid2D;

public class BulletFabric : Fabric<BulletView>
{
    private BulletPool _pool;
    [SerializeField] private int _poolStartCount;
    [SerializeField] private bool _isExpandable;
    [SerializeField] private BulletView _bulletPrefab;
    [SerializeField] private Transform _parentObject;

    private void Awake()
    {
        Setup();
    }
    private void Setup()
    {
        _pool = new BulletPool(_poolStartCount,_isExpandable,
                                _parentObject,_bulletPrefab);
    }

    public void CreateBullet(Vector3 position, Quaternion direction, ObjectType objType)
    {
        BulletView bullet;
        bullet = _pool.BulletObjectPool.GetFreeObjectInPool();
        bullet.transform.parent = _parentObject;
        bullet.transform.position = position;
        bullet.transform.localRotation = direction;
        bullet.SetBulletNewOwner(objType);
        bullet.Move();
    }
    public override void ReturnObjectToPool(BulletView bullet)
    {
        _pool.DeactivateBullet(bullet);
    }
}
