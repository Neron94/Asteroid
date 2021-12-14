using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BaseMVC;
using Asteroid2D;

public class ShootView : BaseView<ShootModel, ShootController>, IShoot, IAlternativeShoot
{
    #region Init
    [SerializeField] private float altWeaponTimer;
    #endregion
    private float _distanceOfAltWeaponRay;
    private Transform _transform;
    private BulletFabric _bulletFabric;
    private Transform _childRotation;
    private Transform _alternativeBullet;


    protected override void Awake()
    {
        base.Awake();
        Setup();
    }
    private void Setup()
    {
        _transform = transform;
        try 
        { 
            _childRotation = transform.GetChild(0);
            _alternativeBullet = _childRotation.transform.GetChild(0);
            _alternativeBullet.gameObject.SetActive(false);
        }
        catch 
        { 
            _childRotation = _transform;
        }
        _bulletFabric = GameObject.Find("Controller").GetComponent<BulletFabric>();
        
    }
    public void Shot(ObjectType obj)
    {
        _bulletFabric.CreateBullet(_transform.position, _childRotation.rotation, obj);
    }
    public void ShotAlternative()
    {
        StartCoroutine(AltShotEffectTimer());
        RaycastHit2D[] rayHit = Physics2D.RaycastAll(_transform.position, 
                                                _childRotation.TransformDirection(Vector3.up));
        foreach(RaycastHit2D hit in rayHit)
        {
            hit.collider.gameObject.GetComponent<IInteractor>().OnInteraction(ObjectType.PlayerShip);
        }
            
    }
    public IEnumerator AltShotEffectTimer()
    {
        _alternativeBullet.gameObject.SetActive(true);
        yield return new WaitForSeconds(altWeaponTimer);
        _alternativeBullet.gameObject.SetActive(false);
    }
}
    