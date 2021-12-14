using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroid2D;

public class AsteroidView : BaseView<AsteroidModel, AsteroidController>, IInteractor
{
    #region Init
    [SerializeField] private bool _isCombineAsteroid;
    [SerializeField] private int _scores;
    [SerializeField] private float _StartInvincibleTime;
    #endregion

    private IMove _move;
    private IScores _scoreController;
    private Transform _transform;
    private AsteroidFabric _fabric;
    private bool _invincibility = true;

    public ObjectType ObjType { get; set; }

    public void OnInteraction(ObjectType objType)
    {
        if (controller.IsDestroyedOnInteraction(objType))
        {
            AsteroidDestroyed();
        }
    }
    public void SetFabric(AsteroidFabric fabric)
    {
        if(this._fabric == null) this._fabric = fabric;
    }
    public void OnCreation()
    {
        InvincibleTime();
        Move();
    }

    protected override void Awake()
    {
        base.Awake();
        Setup();
    }
    private void Move()
    {
        _move.StartMove();
    }
    private IEnumerator InvincibleTime()
    {
        yield return new WaitForSeconds(model.InvincibleTime);
        _invincibility = false;
    }
    private void Setup()
    {
        ObjType = ObjectType.Asteroid;
        model = new AsteroidModel(_scores, _StartInvincibleTime);
        controller = new AsteroidController();
        controller.Setup(model);
        _move = transform.GetComponent<IMove>();
        _transform = transform;
        _scoreController = GameObject.Find("GameHandler").GetComponent<IScores>();
    }
    private void AsteroidDestroyed()
    {
        if (_isCombineAsteroid)
        {
            _fabric.CreateAsteroid(_transform.position,
                                    new Quaternion(0,0,_transform.eulerAngles.z + 45,0), false);
            _fabric.CreateAsteroid(_transform.position,
                                    new Quaternion(0, 0, _transform.eulerAngles.z - 45, 0), false);
            _fabric.ReturnAsteroidToPool(this, _isCombineAsteroid);
            _scoreController.AddScores(model.Scores);
        }
        else
        {
            if(_fabric)
            {
                _fabric.ReturnAsteroidToPool(this, _isCombineAsteroid);
                _scoreController.AddScores(model.Scores);
            }
        }
    }
}
