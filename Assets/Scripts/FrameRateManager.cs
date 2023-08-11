using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRateManager : MonoBehaviour
{
    [SerializeField] int fps = 60;
    void Start()
    {
        Application.targetFrameRate = fps;
    }
}
