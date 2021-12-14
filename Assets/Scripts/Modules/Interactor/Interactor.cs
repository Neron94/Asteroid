using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Interactor : MonoBehaviour
{ 
    private Rigidbody2D _rigidBody;
    private IInteractor _interactor;

    private void Awake()
    {
        Setup();
    }
    private void Setup()
    {
        _rigidBody = transform.GetComponent<Rigidbody2D>();
        _interactor = transform.GetComponent<IInteractor>();
    }
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IInteractor interactorObj = collision.gameObject.GetComponent<IInteractor>();
        if(interactorObj != null) _interactor.OnInteraction(interactorObj.ObjType);
    }
    public void AltWeaponHit()
    {
        _interactor.OnInteraction(Asteroid2D.ObjectType.PlayerShip);
    }
}
