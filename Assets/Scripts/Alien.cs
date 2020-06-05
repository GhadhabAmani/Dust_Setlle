using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rotate a spwan  and display Random Text Number on it 
/// </summary>
public class Alien : MonoBehaviour
{
    void Start()
    {
        // Set the text of the attached Text mesh
      gameObject.GetComponentInChildren<TextMesh>().text = Random.Range(1,20).ToString();
    }

}
