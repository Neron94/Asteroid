using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using BaseMVC;
using Asteroid2D;

[RequireComponent(typeof(GameObject))]
[RequireComponent(typeof(PlayerMoveView))]
[RequireComponent(typeof(ShootView))]
[RequireComponent(typeof(Interactor))]
[RequireComponent(typeof(RotateView))]
public class PlayerView : BaseView<PlayerModel, PlayerController>, IPlayerControll, IInteractor
{
    #region Init Object
    private Transform _transform;
    [SerializeField] private Transform _rotTransform;
    [SerializeField] private float _mainWeaponCountDown;
    [SerializeField] private float _altWeaponCountDown;
    [SerializeField] private UIView _ui;
    #endregion

    private IMove _move;
    private IShoot _shoot;
    private IAlternativeShoot _altShoot;
    private RotateView _rotateView;

    public ObjectType ObjType { get; set; }

    protected override void Awake()
    {
        Setup();
    }
    private void Setup()
    {
        ModuleTypeIs = BaseMVC.ModuleType.Actor;
        _move = transform.GetComponent<IMove>();
        _shoot = transform.GetComponent<ShootView>();
        _altShoot = transform.GetComponent<ShootView>();
        model = new PlayerModel(_mainWeaponCountDown, _altWeaponCountDown);
        controller = new PlayerController();
        controller.Setup(model);
        _rotateView = transform.GetComponent<RotateView>();

        _transform = transform;
        ObjType = ObjectType.PlayerShip;
    }
    private void RotationToUI()
    {
        _ui.RotationChange(Mathf.Ceil(_rotTransform.rotation.eulerAngles.z));
    }
    private void FixedUpdate()
    {
        if (model.TimeFromLastMainWeaponUse != 0)
        {
            controller.MainWeaponCountDown(Time.fixedDeltaTime);
        }
        if (model.TimeFromLastAltWeaponUse != 0)
        {
            controller.AltWeaponCountDown(Time.fixedDeltaTime);
        }
        DestroyPlayer();
        
    }

    public void Rotate(float value)
    {
        _rotateView.Rotate(value);
        RotationToUI();
    }
    public void Shoot()
    {
        if(controller.IsMainWeaponCanShot())
        {
            _shoot.Shot(ObjType);
        }
    }
    public void Thrust()
    {
        _move.StartMove();
    }
    public void ShootAlternative()
    {
        if(controller.IsAltWeaponCanShot())
        {
            _altShoot.ShotAlternative();
        }
    }
    public void OnInteraction(ObjectType objType)
    {
        controller.InteractionDesicion(objType);
    }
    public void DestroyPlayer()
    {
        if(model.IsGameOver)
        {
            _ui.GameOverScreen();
        } 
    }
}
