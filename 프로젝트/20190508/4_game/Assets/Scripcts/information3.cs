﻿using UnityEngine;
using System.Collections;

public class information3 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Uicontroller.info3 = true;
        }
    }

}