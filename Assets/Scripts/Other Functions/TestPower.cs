using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPower : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _rg;
    [SerializeField] private Vector3 _dir;
    [SerializeField] private float _speed;
    
    void Start()
    {
        _rg.AddForce(_dir*_speed, ForceMode2D.Force);
    }

}
