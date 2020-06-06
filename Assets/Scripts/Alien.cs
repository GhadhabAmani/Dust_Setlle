using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

/// <summary>
/// Rotate a spwan  and display Random Text Number on it 
/// </summary>
public class Alien : MonoBehaviour
{
    void Start()
    {
      
      gameObject.GetComponentInChildren<TextMesh>().text = Random.Range(1,20).ToString();
    }
   

}
