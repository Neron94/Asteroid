using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroid2D;
using BaseMVC;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletView : BaseView<BulletModel, BulletController>, IInteractor
{
    #region InitObj
    [SerializeField] private float _lifeTime;
    [SerializeField] private Color _ufoColor;
    [SerializeField] private Color _playerColor;
    #endregion

    private SpriteRenderer _spriteColor;
    private IMove _move;
    private BulletFabric _fabric;
    private Transform _transform;

    public ObjectType ObjType { get; set; }

    protected override void Awake()
    {
        Setup();
    }
    private void ReturnBulletToPool()
    {
        _fabric.ReturnObjectToPool(this);
    }
    private void Update()
    {
        
        if (controller.IsLifeTimeOff(Time.deltaTime)) ReturnBulletToPool();
    }
    private void Setup()
    {
        _transform = transform;
        model = new BulletModel();
        controller = new BulletController();
        controller.Setup(model);
        controller.Init(_lifeTime);
        _move = _transform.GetComponent<MoveView>();
        _fabric = GameObject.Find("Controller").GetComponent<BulletFabric>();

        _spriteColor = _transform.GetComponent<SpriteRenderer>();
    }

    public void SetBulletNewOwner(ObjectType objType)
    {
        ObjType = objType;
        if (objType == ObjectType.PlayerShip)
        {
            _spriteColor.color = _playerColor;
        }
        else _spriteColor.color = _ufoColor;
    }
    public void Move()
    {
        _move.StartMove();
    }
    public void OnInteraction(ObjectType objType)
    {
        if(ObjType != objType)
        {
            if(controller.IsDestroyedOnInteraction(objType)) ReturnBulletToPool();
        }
        
    }
}
