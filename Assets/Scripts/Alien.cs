﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

/// <summary>
/// Rotate a spwan  and display Random Text Number on it 
/// </summary>
public class Alien : MonoBehaviour, INotifyPropertyChanged
{
    public GameObject money;
    private int _damageNumber;
    public int DamageNumber
    {
        get { return _damageNumber; }
        set
        {
            if (_damageNumber != value)
            {
                _damageNumber = value;
            }
        }
    }
    protected void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        PropertyChangedEventHandler handler = PropertyChanged;
        if (handler != null)
            handler(this, e);
    }
    protected void OnPropertyChanged(string propertyName)
    {
        OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
    }
    public event PropertyChangedEventHandler PropertyChanged;
    void Start()
    {
        DamageNumber = Int32.Parse(gameObject.GetComponentInChildren<TextMeshPro>().text);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Weapon")
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Weapon");
            Debug.Log("collisionnnnnn");
            DamageNumber--;
            OnPropertyChanged("Number Has changed");
            gameObject.GetComponentInChildren<TextMeshPro>().text = DamageNumber.ToString();
            Debug.Log(DamageNumber);
            Destroy(obj);
        }
        if (DamageNumber == 0)
        {
            Destroy(gameObject);
            Instantiate(money, transform.position, transform.rotation);
        }
    }

}



