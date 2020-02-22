using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    private Transform plane_transform;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        plane_transform = GetComponent<Transform>();
        speed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            plane_transform.Rotate(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            plane_transform.Rotate(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            plane_transform.Rotate(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            plane_transform.Rotate(-speed, 0, 0);
        }
    }
}
