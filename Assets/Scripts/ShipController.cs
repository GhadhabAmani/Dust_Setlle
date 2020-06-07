
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    private Transform reference;
    public float speedRotate = 0.2f;
    public float speedDirecton = 0.2f;
    private Weapon _weapon;

    private void Awake()
    {
        reference = gameObject.GetComponent<Transform>();
        _weapon = GetComponentInChildren<Weapon>();
    }

    private bool _firing;
    public bool Firing
    {
        get { return _firing; }
        set
        {
            if (_firing != value)
            {
                _firing = value;
                if (_firing)
                    //_weapon.InvokeRepeating("Fire", 1f / _weapon.firingRate, 1f / _weapon.firingRate);
                    _weapon.Invoke("Fire",  1f / _weapon.firingRate);
            }
        }
    }
    void Update()
    {

#if ((!UNITY_EDITOR) && (UNITY_ANDROID || UNITY_IOS) || !REMOTE)
        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];
            if (touch.phase == TouchPhase.Moved)
            {
                reference.transform.rotation *= Quaternion.Euler(0f, 0f, -touch.deltaPosition.x * speedRotate);
                reference.transform.position += new Vector3(0f, touch.deltaPosition.y * speedDirecton, 0f);
            }
            //TODO : Fix Number of Touch
            if (touch.tapCount >= 2)
            {
                Firing = true;
            }
        }
#else
            float y = Input.GetAxis("Vertical");
            float z = Input.GetAxis("Horizontal");
            Firing = Input.GetButton("Fire2");
            reference.transform.Translate(0, y * speedDirecton, 0, Space.World);
            reference.transform.Rotate(0, 0, -z * speedRotate, Space.World);
#endif

    }
}
