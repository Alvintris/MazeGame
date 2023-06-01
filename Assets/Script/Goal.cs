using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public Canvas canvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canvas.enabled = true;
    }
}
