using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    //added hiscore counter
    [SerializeField] private Text _score;
    [SerializeField] private Text _hiScore;

    public static int _scoreCount = 0;
    public static int _hiScoreCount = 0;

    private void Start()
    {
        _score.text = "SCORE    " + _scoreCount.ToString();
        _hiScore.text = "HISCORE    " + _hiScoreCount.ToString();
    }

    private void Update()
    {
        _score.text = "SCORE    " + _scoreCount.ToString();
    }
}
