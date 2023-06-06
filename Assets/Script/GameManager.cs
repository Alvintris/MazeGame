using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Canvas mainMenuUI;
    [SerializeField] private Canvas finishGame;
    [SerializeField] private GameObject player;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = player.transform.position;
        mainMenuUI.enabled = true;
        finishGame.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exit();
        }
    }

    public void PlayMenu()
    {
        mainMenuUI.enabled = false;
        player.transform.position = startPosition;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Back()
    {
        finishGame.enabled = false;
        mainMenuUI.enabled = true;
    }

    public void FinishPanel()
    {
        finishGame.enabled = true;
    }
}
