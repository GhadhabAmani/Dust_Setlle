using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [Header("GUI")]
    public Text score;
    public Text highScore;
    public Slider scoreSlider;
    public Color scoreColor;
    private void Start()
    {
        score.text = string.Format("SCORE : {0} ", GameManager.Score).ToString();
        highScore.text = string.Format("HIGHSCORE : {0} ", GameManager.HighScore).ToString();
        GameManager.ScoreChanged += delegate (int _score)
        {
            score.text = string.Format("SCORE : {0} ", _score).ToString();
        };
        GameManager.highScoreChanged += delegate (int _highScore)
        {
            highScore.text = string.Format("HIGHSCORE : {0}", _highScore).ToString();
        };

    }

}
