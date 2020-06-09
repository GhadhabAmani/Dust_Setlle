using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager 
{
    public delegate void ScoreChange(int score);
    static public event ScoreChange ScoreChanged;

    public delegate void highScoreChange(int score);
    static public event highScoreChange highScoreChanged;
    enum STATE
    {
        Running,
        Paused,
        GameOver,
    }
    private static int _highScore =100;
    public static int HighScore
    {
        get { return _highScore; }
        set
        {
            if (_highScore != value)
            {
                _highScore = value;
                Debug.Log(value);
                if (highScoreChanged != null)
                {
                    highScoreChanged.Invoke(_highScore);
                }
            }
        }
    }
    private static int _score;
    public static int Score
    {
        get { return _score; }
        set
        {
            if(_score != value)
            {
                _score = value;
                Debug.Log(value);
                if (ScoreChanged !=null)
                {
                    ScoreChanged.Invoke(_score);
                }
                if (_score >= HighScore)
                {
                    HighScore = _score;
                }
            }
        }
    }


    private static int _live;
    public static int Lives 
    {
        get { return _live; }
        set
        {
            if (_live != value)
            {
                _live = value ;
            }
        }
    }


  
}
