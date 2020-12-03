﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float sensivity = 1;
    public float rotateX = 0;
    public float rotateY = 0;
    public Transform Target, Player;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        moveCamera();
    }
    void moveCamera()
    {
        rotateX += Input.GetAxis("Mouse X")*sensivity;
        rotateY -= Input.GetAxis("Mouse Y")*sensivity;
        rotateY = Mathf.Clamp(rotateY, -35, 60);
        transform.LookAt(Target);
        Target.rotation = Quaternion.Euler(rotateY, rotateX, 0);
        Player.rotation = Quaternion.Euler(0, rotateX, 0); 
    }
}
