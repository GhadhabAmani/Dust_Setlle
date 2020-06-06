using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 0.5f;
    public float range = 5f;
    private float _distance;

    void FixedUpdate()
    {
        transform.Translate(new Vector3(0, -speed * Time.fixedDeltaTime, 0), Space.Self);
        _distance += speed * Time.fixedDeltaTime;
        if (_distance>range)
        {
            Destroy(gameObject);
        }
    }
}
