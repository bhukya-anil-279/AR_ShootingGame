using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool isGameover;
    public GameObject PauseMenu;
    public static int Score;
    public GameObject gameover;
  

    // Start is called before the first frame update
    void Start()
    {
       isGameover = false;
        gameover.SetActive(false);
        PauseMenu.SetActive(false);
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if(isGameover)
        {
            gameover.SetActive(true);
        }

        if (Score > PlayerPrefs.GetInt("highscore", 0))
        { PlayerPrefs.SetInt("highscore", Score); }

    }


    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);

    }

    public void ResumeGame ()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Retry()
    {
        SceneManager.LoadScene("ShootGame");
    }

}
