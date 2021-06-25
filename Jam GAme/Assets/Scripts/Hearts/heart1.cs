using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart1 : MonoBehaviour
{
    public GameObject heart01;

    void Start()
    {
        
    }


    void Update()
    {
        if (DragDrop.health >= 1)
        {
            heart01.SetActive(true);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
