using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateView : MonoBehaviour
{
    [SerializeField] private float RotationSpeedFactor;
    private const float  ROTATION_DEFAULT_SPEED = 1;
    public Transform RotTransform { get; private set; }
    private float _defaultScaleFactor;

    private void Awake()
    {
        Setup();
        if (RotationSpeedFactor == 0) RotationSpeedFactor = ROTATION_DEFAULT_SPEED;
    }
    private void Setup()
    {
        RotTransform = transform.GetChild(0);
        _defaultScaleFactor = 2;
    }
    public void Rotate(float value)
    {
        RotTransform.Rotate(0, 0, -value * RotationSpeedFactor);
    }
}
    