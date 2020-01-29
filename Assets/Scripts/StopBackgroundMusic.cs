using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBackgroundMusic : MonoBehaviour
{
    void Awake()
    {
        GameObject backgroundMusic = GameObject.FindGameObjectWithTag("BackgroundMusic");
        Destroy(backgroundMusic);
    }
}
