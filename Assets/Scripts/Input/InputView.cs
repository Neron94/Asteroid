using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputView : BaseView<InputModel, InputController>
{

    [SerializeField] private AsteroidInput _input;
    private IPlayerControll _playerController;
    [SerializeField] private Transform _playerTransform;
    
    
    protected override void Awake()
    {
        base.Awake();
        Setup();
    }
    private void Setup()
    {
        _playerController = _playerTransform.GetComponent<IPlayerControll>();
        _input = new AsteroidInput();
        model = new InputModel();
        controller.Setup(model);

        _input.ShipControll.Thrust.performed += _ => { controller.IsThrust = true; };
        _input.ShipControll.Thrust.canceled += _ => { controller.IsThrust = false; };
        _input.ShipControll.Rotation.performed += _ => { controller.IsRotate = true; };
        _input.ShipControll.Rotation.canceled += _ => { controller.IsRotate = false; };
        _input.ShipControll.FireMainWeapon.performed += _ => FireMainPlayer();
        _input.ShipControll.FireAlternativeWeapon.performed += _ => FireAlternativePlayer();
    }
    private void Update()
    {
        if (model.IsRotate) RotatePlayer();
        if (model.IsThrust) ThrustPlayer();
    }
    private void ThrustPlayer()
    {
       
        _playerController.Thrust();
    }
    private void RotatePlayer()
    {
        _playerController.Rotate(_input.ShipControll.Rotation.ReadValue<float>());
    }
    private void FireMainPlayer()
    {
        _playerController.Shoot();
    }
    private void FireAlternativePlayer()
    {
        _playerController.ShootAlternative();
    }
    private void OnEnable()
    {
        _input.Enable();
    }
    private void OnDisable()
    {
        _input.Disable();
    }
}
