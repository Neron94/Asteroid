using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool
{
    public ObjectPool<BulletView> BulletObjectPool;

    public BulletPool(int _poolStartCount, bool _isExpendable, Transform _parentObject, BulletView _bulletPrefab)
    {
        BulletObjectPool = new ObjectPool<BulletView>(_bulletPrefab, _poolStartCount, _parentObject, _isExpendable);
    }
    public void DeactivateBullet(BulletView bullet)
    {
        BulletObjectPool.ReturnObjectToPool(bullet);
    }
}
