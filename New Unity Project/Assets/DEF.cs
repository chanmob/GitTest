using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEF : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
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
