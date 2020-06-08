using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public Transform target;
    Vector3 targetPos;
    Vector3 targetScale;
    public float delay = 1000f;
    public float speed = 1;
    private void Start()
    {
        targetPos = target.position;
        targetScale = target.localScale;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
        transform.localScale = Vector3.MoveTowards(transform.localScale, targetScale, delay + Time.deltaTime * speed);
    }
}
