using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Video;

/// <summary>
/// Rotate a spwan  and display Random Text Number on it 
/// </summary>
public class Alien : MonoBehaviour
{
    void Start()
    {
      gameObject.GetComponentInChildren<TextMeshPro>().text = Random.Range(1,9).ToString();
    }
   

}
