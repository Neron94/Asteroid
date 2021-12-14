using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidFabric : Fabric<AsteroidView>
{
    private AsteroidBigPool _bigPool;
    private AsteroidSmallPool _smallPool;
    [SerializeField] private int _startCount;
    [SerializeField] private bool _isExpandable;
    [SerializeField] private Transform _parentObject;
    [SerializeField] private AsteroidView _prefabBig;
    [SerializeField] private AsteroidView _smallPrefab;
    [SerializeField] private List<AsteroidView> _asteroidList;

    private void Awake()
    {
        Setup();
    }
    private void Setup()
    {
        _bigPool = new AsteroidBigPool(_startCount,_isExpandable, _parentObject, _prefabBig);
        _smallPool = new AsteroidSmallPool(_startCount, _isExpandable, _parentObject, _smallPrefab);
    }

    public void CreateAsteroid(Vector3 position, Quaternion direction, bool isBig)
    {
        AsteroidView asteroid;

        if (isBig) asteroid = _bigPool.AsteroidPool.GetFreeObjectInPool();
        else asteroid = _smallPool.AsteroidPool.GetFreeObjectInPool();

        asteroid.transform.parent = _parentObject;
        asteroid.SetFabric(this);
        asteroid.transform.position = position;
        asteroid.transform.Rotate(Vector3.forward,direction.z);
        asteroid.OnCreation();
        _asteroidList.Add(asteroid);
    }
    public void ReturnAsteroidToPool(AsteroidView asteroid, bool isBig)
    {
        if (isBig)_bigPool.DeactivateAsteroid(asteroid);
        else _smallPool.DeactivateAsteroid(asteroid);
        _asteroidList.Remove(asteroid);
    }
    public bool IsNoOneAsteroidLeft()
    {
        if (_asteroidList.Count > 0) return false;
        return true;
    }
}
