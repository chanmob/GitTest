﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEF : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        gameObject.name = "DEF";
    }

    private void Awake()
    {
        gameObject.SetActive(true);
    }
}
