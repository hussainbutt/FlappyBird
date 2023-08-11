using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void StartMenu()
    {
        if (gameObject.name.Equals("Play"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (gameObject.name.Equals("Exit"))
        {
            Application.Quit();
        }
        if (gameObject.name.Equals("PlayAgain"))
        {
            SceneManager.LoadScene(0);
        }
    }

}
