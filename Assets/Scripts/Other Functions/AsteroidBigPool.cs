using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBigPool
{
    public ObjectPool<AsteroidView> AsteroidPool;
    public AsteroidBigPool(int startCount, bool isExpandable, Transform parentObject, AsteroidView prefab)
    {
        AsteroidPool = new ObjectPool<AsteroidView>(prefab, startCount, parentObject, isExpandable);
    }
    public void DeactivateAsteroid(AsteroidView asteroid)
    {
        AsteroidPool.ReturnObjectToPool(asteroid);
    }
}
