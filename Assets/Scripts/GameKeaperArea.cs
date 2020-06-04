using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameKeaperArea : MonoBehaviour
{

    [Header("Game Area Properties")]


    public Color color = Color.red;
    public Rect gameArea;
    //[Header("GameObject into loop")]
    //public Transform reference;
    //private Vector3 pos;
    private Vector3 pos;
    private void Start()
    {
        gameArea.center = Vector2.zero;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawCube(Vector3.zero, new Vector2(gameArea.width, gameArea.height));
    }
    void Update()
    {
        pos = gameObject.transform.position;

        if (gameArea.Contains(gameObject.transform.position))
            return;
        
            if (pos.x >gameArea.xMax)
            {
                pos.x = gameArea.xMin;
            }
            else if (pos.x <gameArea.xMin)
            {
                pos.x = gameArea.xMin;
            }
            else if (pos.y >gameArea.yMax)
            {
                pos.y = gameArea.yMin;
            }
            else if (pos.y < gameArea.yMin)
            {
                pos.y = gameArea.yMax;
            }
        transform.position = pos;
    }
}
