using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicQueue : MonoBehaviour
{
    int buildIndex = 0;
    public AudioClip[] musicObj;
    private AudioSource musicSource;
    private void Start()
    {
        musicSource = GetComponent<AudioSource>();
        musicSource.clip = musicObj[buildIndex];
        musicSource.Play();
    }
    private void Update()
    {
        int updatedBuildIndex = SceneManager.GetActiveScene().buildIndex;
        if (updatedBuildIndex != buildIndex)
        {
            musicSource = GetComponent<AudioSource>();
            buildIndex = updatedBuildIndex;
            musicSource.pitch = (float)(Math.Pow((double)updatedBuildIndex, 1.0 / 3.0) * 0.8);
            musicSource.clip = musicObj[buildIndex];
            musicSource.Play();
            
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

}
