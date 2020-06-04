using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;

public class GameKeaperArea : MonoBehaviour
{

 
    public GameArea gameArea;
    private Vector3 pos = Vector3.zero;
    void Update()
    {
        pos = gameObject.transform.position;

        if (gameArea.GameAreaUI.Contains(gameObject.transform.position))
            return;
        
            if (pos.x >gameArea.GameAreaUI.xMax)
            {
                pos.x = gameArea.GameAreaUI.xMin;
            }
            else if (pos.x <gameArea.GameAreaUI.xMin)
            {
                pos.x = gameArea.GameAreaUI.xMin;
            }
            else if (pos.y >gameArea.GameAreaUI.yMax)
            {
                pos.y = gameArea.GameAreaUI.yMin;
            }
            else if (pos.y < gameArea.GameAreaUI.yMin)
            {
                pos.y = gameArea.GameAreaUI.yMax;
            }
        transform.position = pos;
    }
}
