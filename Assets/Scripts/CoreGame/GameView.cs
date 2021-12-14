using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Asteroid2D
{
    public enum ActorType
    {
        Asteroid, 
        PlayerShip, 
        PlayerBullet, 
        UFO, 
        UFOBullet
    }
    public enum ObjectType
    {
        PlayerShip, 
        Asteroid,
        UFO
    }
}

public class GameView : BaseView<GameModel, GameController>, IScores
{
    #region Init
    [SerializeField] private int _startAsteroidCount;
    [SerializeField] private float _timeToUfo;
    [SerializeField] private float _timeToNextRound;
    [SerializeField] private UfoView _ufoPrefab;
    [SerializeField] private Transform _asteroidParentObject;
    [SerializeField] private UIView _ui;
    #endregion
    private RandomPositionGenerator _randomPosGen;
    private AsteroidFabric _asteroidFabric;

    protected override void Awake()
    {
        Setup();
    }
    private void Setup()
    {
        _asteroidFabric = transform.GetChild(0).GetComponent<AsteroidFabric>();
        _randomPosGen = new RandomPositionGenerator((Camera.main.orthographicSize * 2)* Camera.main.aspect, 
                                                     Camera.main.orthographicSize*2, 1);
        model = new GameModel(_startAsteroidCount, _timeToUfo, _timeToNextRound);
        controller = new GameController();
        controller.Setup(model);
    }
    private void Start()
    {
        SpawnAsteroids(model.StartAsteroidCount);
        _ui.RoundChange(model.RoundCount);
        _ui.ScoreChange(model.Scores);
    }
    private void Update()
    {
        if (IsTimeToUfo()) SpawnUFO();
        if (IsTimeToNewRound()) NewRound();
    }
    private bool IsTimeToNewRound()
    {
        if(_asteroidFabric.IsNoOneAsteroidLeft())
        {
            if(controller.IsTimeToNewRound(Time.deltaTime))
            {
                return true;
            }
        }
        return false;
    }
    private void NewRound()
    {
        controller.InitNewRound();
        _ui.RoundChange(model.RoundCount);
        SpawnAsteroids(model.AsteroidToSpawnCount);
    }
    private void SpawnAsteroids(int count)
    {
        for (int i = 0; i < count; i++)
        {
            _asteroidFabric.CreateAsteroid(_randomPosGen.GetBoundriesPosition(),
                                                    new Quaternion(0, 0, Random.Range(1, 180), 0), true);
        }
    }
    private bool IsTimeToUfo()
    {
        if (_ufoPrefab.isActiveAndEnabled == false)
        {
            if (controller.IsTimeToUfo(Time.deltaTime))
            {
                return true;
            }
        }
        return false;
    }
    private void SpawnUFO()
    {
        _ufoPrefab.transform.position = _randomPosGen.GetBoundriesPosition();

        if (_ufoPrefab.isActiveAndEnabled == false)
        {
            _ufoPrefab.gameObject.SetActive(true);
        }
        
    }
    public void AddScores(int score)
    {
        controller.AddScoresToModel(score);
        _ui.ScoreChange(model.Scores);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

}
