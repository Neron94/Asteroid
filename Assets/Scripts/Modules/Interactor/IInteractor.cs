using UnityEngine;
using Asteroid2D;

public interface IInteractor 
{
    public ObjectType ObjType { get; set; }
    public void OnInteraction(ObjectType objType);
}
