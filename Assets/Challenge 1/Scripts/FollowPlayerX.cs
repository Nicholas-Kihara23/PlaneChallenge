﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 cameraOffset = new Vector3(64, 0, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //cameraOffset used to make it stay to the side of the plane
        transform.position = plane.transform.position + cameraOffset;
    }
}
