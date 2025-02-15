﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicController : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("BackgroundMusic");
        if (objects.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
