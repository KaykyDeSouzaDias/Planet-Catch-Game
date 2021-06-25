using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class redBlackHUD : MonoBehaviour
{
    public TextMeshProUGUI planetNumb;

    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        planetNumb.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);
    }
}
