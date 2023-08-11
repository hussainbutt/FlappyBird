using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    private string currentSceneName;
    void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
        
    }
    private void Update()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
        if (SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().name == "End")
        {
            Destroy(this.gameObject);
        }
    }


    void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("Music");

        DontDestroyOnLoad(this);
    }
}