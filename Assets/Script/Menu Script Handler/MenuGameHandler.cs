using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGameHandler : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 startPos;

    private void Start()
    {
        Time.timeScale = 1;
        startPos = player.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = startPos;
    }
}
