using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PauseMenu : MonoBehaviour
{
    public static bool isMenuOpen = false;
    public GameObject pauseMenuUI;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            openMenu();
        }
    }
    public void openMenu()
    {
        if (!isMenuOpen)
        {
            Pause();
        }
        else if (isMenuOpen)
        {
            resume();
        }
    }
    public void resume()
    {
        Time.timeScale = 1.0f;
        pauseMenuUI.SetActive(false);
        isMenuOpen = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isMenuOpen = true;

    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }
}