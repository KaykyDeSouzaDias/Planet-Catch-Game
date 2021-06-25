using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragDrop : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject correctPlace;
    public Transform target;

    public static int health = 3;
    bool isConnected;
    float speed = 2f;
    public static int count = 0;

    void Update()
    {
        if (!isConnected)
        {
            transform.position = Vector2.MoveTowards(transform.position,
                                 target.position, speed * Time.deltaTime);
        }
    }

    void OnMouseDrag()
    {
        if (!isConnected)
        {
            transform.position = getMousePos();
        }
    }

    Vector2 getMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return mousePos;
    }

    void OnMouseUp()
    {
        if (Mathf.Abs(this.transform.position.x - correctPlace.transform.position.x) <= 0.5f &&
            Mathf.Abs(this.transform.position.y - correctPlace.transform.position.y) <= 0.5f)
        {
            this.transform.position = new Vector2(correctPlace.transform.position.x, correctPlace.transform.position.y);
            isConnected = true;
            count += 1;
        }
        else
        {
            health -= 1;
            Destroy(gameObject);
        }
    }
}
