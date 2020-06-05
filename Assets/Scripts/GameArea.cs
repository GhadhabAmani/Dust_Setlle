using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameArea : MonoBehaviour
{
    [Header("Area Properties")]
    public Color color;
    public Vector2 size;

    private Rect gameArea;
    public Rect GameAreaUI
    {
        get { return gameArea; }
        set
        {
            if (gameArea != value)
            {
                gameArea = value;
            }
        }
    }
    private void setSize(Vector2 size)
    {
        GameAreaUI = new Rect(size.x *- 0.5f, size.y *- 0.5f, size.x, size.y);
    }
    private void OnValidate()
    {
        setSize(size);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawCube(Vector3.zero, new Vector2(gameArea.width, gameArea.height));
    }
    public Vector3 RandomPosition()
    {
        Vector3 pos;
        float x = Random.Range(-size.x / 2, size.x/2 );
        float y = Random.Range(0.3f, size.y/2);
        pos = new Vector3(x, y, 0);
        return pos;
    }

}
