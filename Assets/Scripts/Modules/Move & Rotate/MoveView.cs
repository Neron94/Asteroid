using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BaseMVC;

[RequireComponent(typeof(GameObject))]
public class MoveView : BaseView<MoveModel,MoveController>, IMove
{
    #region Init Object

    [Range(1, 8)]
    [Tooltip("For player ship Default value is 3")]
    [SerializeField] private float _speed;
    #endregion
    
    private Transform _transform;
    
    protected override void Awake()
    {
        Setup();
    }
    private void Setup()
    {
        ModuleTypeIs = ModuleType.Utility;
        model = new MoveModel(_speed, true, 2);
        controller = new MoveController();
        controller.Setup(model);

        _transform = transform;
    }
    private void FixedUpdate()
    {
        MoveForward();
    }
    private void MoveForward()
    {
        Vector3 _direction = new Vector3(0, model.CurThrustPower, 0);
        _transform.Translate( _direction * Time.fixedDeltaTime);
    }

    public void StartMove()
    {
        controller.InitMove();
    }
}
