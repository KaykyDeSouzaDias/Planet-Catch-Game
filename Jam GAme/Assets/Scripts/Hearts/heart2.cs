using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart2 : MonoBehaviour
{
    public GameObject heart02;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DragDrop.health >= 2)
        {
            heart02.SetActive(true);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
