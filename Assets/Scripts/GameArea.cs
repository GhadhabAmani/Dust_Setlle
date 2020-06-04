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

}
