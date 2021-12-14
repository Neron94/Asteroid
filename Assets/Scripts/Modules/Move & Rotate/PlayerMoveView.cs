using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveView : BaseView<PlayerMoveModel, PlayerMoveController>, IMove
{
    #region Init Object

    [Range(1, 8)]
    [Tooltip("For player ship Default value is 3")]
    [SerializeField] private float _speed;
    private enum ObjectType
    {
        Ship,
        Asteroid,
        UFO
    }
    [Tooltip("What kind of object is owner of MoveView")]
    [SerializeField] private ObjectType ObjType;

    #endregion

    private Transform _transform;
    private Transform _rotateTransform;

    protected override void Awake()
    {
        Setup();
    }
    private void Setup()
    {
        model = new PlayerMoveModel(_speed, true, 2);
        controller = new PlayerMoveController();
        controller.Setup(model);

        _transform = transform;
        _rotateTransform = transform.GetChild(0);
    }
    private void FixedUpdate()
    {
        MoveForward();
        if (ObjType == ObjectType.Ship) controller.SlowThrust(Time.deltaTime);
    }
    private void MoveForward()
    {
        Vector3 _direction = new Vector3(0, model.CurThrustPower, 0);
        _transform.Translate(_direction * Time.fixedDeltaTime);
    }
    private void RotationToTransform()
    {
        //Повороты и перемещения разделены на 2 трансформа 
        //При перемещении направления подается из трансформа для поворотов
        //Таким образом осуществляется магическое скольжение 
        //корабля с возможностью вертется при скольжении
        _transform.rotation = _rotateTransform.rotation;
        _rotateTransform.rotation = new Quaternion();

    }

    public void StartMove()
    {
        RotationToTransform();
        controller.InitMove();
    }
}
