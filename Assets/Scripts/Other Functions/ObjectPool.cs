using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : MonoBehaviour
{
    private List<T> _objectPool;

    private T Prefab;
    private bool IsExpandable;
    private Transform ContainerObject;
    
    public ObjectPool(T prefab, int count, bool isExpand)
    {
        Prefab = prefab;
        ContainerObject = null;
        IsExpandable = isExpand;
        CreatePool(count);
    }
    public ObjectPool(T prefab, int count, Transform container, bool isExpand)
    {
        Prefab = prefab;
        ContainerObject = container;
        IsExpandable = isExpand;
        CreatePool(count);
        
    }

    private void CreatePool(int count)
    {
        _objectPool = new List<T>();
        for (int i = 0; i < count; i++)
        {
            CreateObject();
        }
    }
    private T CreateObject(bool isActiveByDefault = false)
    {
        var createdObject = Object.Instantiate(Prefab, ContainerObject);
        createdObject.gameObject.SetActive(isActiveByDefault);
        _objectPool.Add(createdObject);
        return createdObject;
    }

    public bool HaveFreeObjectInPool(out T element)
    {
        foreach (var objectInPool in _objectPool)
        {
            if(objectInPool.gameObject.activeInHierarchy == false)
            {
                element = objectInPool;
                objectInPool.gameObject.SetActive(true);
                return true;
            }
        }
        element = null;
        return false;
    }
    public T GetFreeObjectInPool()
    {
        if (HaveFreeObjectInPool(out T element))
            return element;
        if (IsExpandable)
            return CreateObject(true);

        throw new System.Exception($"Have no free elements in pool {typeof(T)}");
    }
    public void ReturnObjectToPool(T element)
    {
        element.transform.position = new Vector3(0,0,0);
        element.gameObject.SetActive(false);
    }
}
