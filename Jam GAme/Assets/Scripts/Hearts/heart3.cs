using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart3 : MonoBehaviour
{
    public GameObject heart03;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DragDrop.health == 3)
        {
            heart03.SetActive(true);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
