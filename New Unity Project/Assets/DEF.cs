﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEF : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //충돌
        gameObject.SetActive(false);
        gameObject.name = "DEF";
    }

    private void Awake()
    {
        gameObject.SetActive(true);
    }

    void A()
    {
        Debug.Log("A");
    }

    void B()
    {
        Debug.LogWarning("B");
    }

    void C()
    {
        Debug.LogError("C");
    }
}
