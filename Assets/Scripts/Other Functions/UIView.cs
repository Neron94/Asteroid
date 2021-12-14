using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIView : MonoBehaviour
{
    [SerializeField] private Text _scrores;
    [SerializeField] private Text _totalScore;
    [SerializeField] private Text _shipRotation;
    [SerializeField] private Text _round;
    [SerializeField] private GameObject _gameOverScreen;

    public void ScoreChange(int score)
    {
        _scrores.text = score.ToString();
        _totalScore.text = score.ToString();
    }
    public void RotationChange(float rotation)
    {
        _shipRotation.text = rotation.ToString();
    }
    public void RoundChange(int round)
    {
        _round.text = round.ToString();
    }
    public void GameOverScreen()
    {
        _gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }

}
