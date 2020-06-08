using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Instantiate enemies +
/// Random Position +
/// Random Text Number
/// Rotate Enemies 
/// </summary>
public class Spawn : MonoBehaviour
{
    [Header("SPAWNING")]
    public GameObject enemy;
    [Range(0.001f, 100)] public float rate;
    [Range(0, 30)] public int numberOfEnemies;
    public bool infinitie = false;
    private Vector3 _position;
    public GameArea gameArea;
    public float minDistance;
    private IEnumerator Start()
    {
        while (infinitie || numberOfEnemies > 0)
        {
            _position = gameArea.RandomPosition();
            if(Math.Sqrt(Math.Pow( (_position- transform.position).x ,2)+Math.Pow ((_position - transform.position).y,2) )< minDistance)
            {
                //TODO : Gerer le decalage
                _position *= 1.2f;
            }
            Instantiate(enemy, _position, transform.rotation);
            numberOfEnemies--;
            yield return new WaitForSeconds(rate);
        }
    }

}
