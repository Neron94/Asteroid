using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSmallPool
{
    public ObjectPool<AsteroidView> AsteroidPool;
    public AsteroidSmallPool(int startCount, bool isExpandable, Transform parentObject, AsteroidView prefab)
    {
        AsteroidPool = new ObjectPool<AsteroidView>(prefab, startCount, parentObject, isExpandable);
    }
    public void DeactivateAsteroid(AsteroidView asteroid)
    {
        AsteroidPool.ReturnObjectToPool(asteroid);
    }
}
