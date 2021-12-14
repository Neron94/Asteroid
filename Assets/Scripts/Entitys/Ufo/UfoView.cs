using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroid2D;

[RequireComponent(typeof(GameObject))]
public class UfoView : BaseView<UfoModel,UfoController>, IInteractor
{
    #region Init
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _mainWeaponCountDown;
    [SerializeField] private int Score;
    #endregion
    private IMove _move;
    private IScores _scoreController;
    private IShoot _shoot;
    private Transform _transform;
    public ObjectType ObjType { get; set; }


    protected override void Awake()
    {
        Setup();
    }   
    private void Update()
    {
        controller.MainWeaponCountDown(Time.deltaTime);
        if (controller.IsMainWeaponCanShot()) Shoot();
    }
    private void Setup()
    {
        if (_playerTransform == null) _playerTransform = GameObject.Find("Player").transform;
        _move = transform.GetComponent<IMove>();
        _shoot = transform.GetComponent<IShoot>();
        ObjType = ObjectType.UFO;
        model = new UfoModel(_mainWeaponCountDown, Score);
        controller = new UfoController();
        controller.Setup(model);
        gameObject.SetActive(false);
        _transform = transform;
        _scoreController = GameObject.Find("GameHandler").GetComponent<IScores>();
    }
    private void OnEnable()
    {
        InitUFO();
        Move();
    }
    private void Move()
    {
        _move.StartMove();
    }
    private void Shoot()
    {
        _shoot.Shot(ObjType);
    }
    private void RotateToTarget()
    {
        Vector3 direction = _playerTransform.position - _transform.position;
        float angleToTarget = Vector3.Angle(direction, Vector3.up);
        if (direction.x > 0) angleToTarget = angleToTarget * -1;
        _transform.rotation = Quaternion.Euler(0, 0, angleToTarget);
    }
    private void InitUFO()
    {
        RotateToTarget();
    }
    private void Destroyed()
    {
        gameObject.SetActive(false);
        _scoreController.AddScores(model.Score);
    }
    public void OnInteraction(ObjectType objType)
    {
        if (controller.IsDestroyedOnInteraction(objType)) Destroyed();
    }
}
