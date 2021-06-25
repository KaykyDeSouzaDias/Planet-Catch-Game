using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map_Behavior : MonoBehaviour
{   
    void Update()
    {
        if (DragDrop.health <= 0)
        {
            SceneManager.LoadScene("Searching");
            DragDrop.health = 3;
        }
        if (DragDrop.count >= 8)
        {
            SceneManager.LoadScene("Searching");
            DragDrop.count = 0;
            DragDrop.health = 3;
        }
    }
}
