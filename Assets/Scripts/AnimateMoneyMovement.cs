using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateMoneyMovement : MonoBehaviour
{
    Vector3 currentPosition;
    public Transform targetPosition;
    Rigidbody2D rb;
    public Vector3 speedDirection = new Vector3(0.3f, 0.3f, 0.3f);
    private void Awake()
    {
        currentPosition = transform.position;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        // move to a specific postion
        rb.MovePosition(targetPosition.position);
    }
}
