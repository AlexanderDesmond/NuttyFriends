using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopStoryMusic : MonoBehaviour
{
    void Awake()
    {
        GameObject backgroundMusic = GameObject.FindGameObjectWithTag("StoryMusic");
        Destroy(backgroundMusic);
    }
}
