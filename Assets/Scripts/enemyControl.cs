using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyControl : MonoBehaviour
{
    private Text enemyNumberText;
    

    private  int _number ;
    public  int Number
    {
        get { return _number; }
        set
        {
            if (_number != value)
            {
                _number = value;
            }
        }
    }
    private void random()
    {
        Number= Random.Range(1, 5);
    }
    void Start()
    {
        enemyNumberText = gameObject.GetComponentInChildren<Text>();
        random();
        enemyNumberText.text = Number.ToString();
    }
 

}
