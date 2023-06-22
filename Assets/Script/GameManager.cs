using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Vector3 startPos;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject pauseMenu;
    public static GameObject victoryMenu;

    private void Start()
    {
        //Get GameObject
        victoryMenu = GameObject.Find("Victory Panel");

        //Make game not pause
        Time.timeScale = 1;

        //Turn off menu screen
        pauseMenu.SetActive(false);
        victoryMenu.SetActive(false);

        //Take player start position
        startPos = player.transform.position;
    }

    private void Update()
    {
        PauseButton();
    }

    public void PauseButton()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.activeInHierarchy == false)
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
            }
        }
    }

    public void NextButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void BackButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
