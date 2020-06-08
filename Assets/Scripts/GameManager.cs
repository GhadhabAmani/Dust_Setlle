using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager 
{

    private static int _highScore = 200;
    public static int HighScore
    {
        get { return _highScore; }
        set
        {
            if (_highScore != value)
            {
                _highScore = value;
                PlayerPrefs.SetInt("highScore", _highScore);
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
                if (_score == HighScore)
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
