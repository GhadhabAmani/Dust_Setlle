using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float firingRate = 1f;
    public GameObject projectile;
    public void Fire()
    {
        Instantiate(projectile, transform.position, transform.rotation);
    }
}
