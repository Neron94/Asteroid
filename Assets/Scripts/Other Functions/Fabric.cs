using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fabric<T> : MonoBehaviour
{
    public virtual void CreateObject() { }
    public virtual void CreateObject(Vector3 pos, Vector3 dir) { }
    public virtual void ReturnObjectToPool(T obj) { }
}
