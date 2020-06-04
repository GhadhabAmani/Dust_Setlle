
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    private Transform reference;
    public float speedRotate = 0.2f;
    public float speedDirecton = 0.2f;


    private void Awake()
    {
        reference = gameObject.GetComponent<Transform>();
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
        }
#else
        float y = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Horizontal");
        reference.transform.Translate(0, y * speedDirecton, 0, Space.World);
        reference.transform.Rotate(0, 0, -z * speedRotate, Space.World);
#endif

    }
}
