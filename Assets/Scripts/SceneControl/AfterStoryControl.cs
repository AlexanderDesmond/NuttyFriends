using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AfterStoryControl : MonoBehaviour
{
    public void ToCollectFact()
    {
        StartCoroutine(DelaySceneLoad("CollectFact"));
    }

    public void ToAlmondFact()
    {
        StartCoroutine(DelaySceneLoad("NutFact_Almond"));
    }

    public void ToMissionComplete()
    {
        StartCoroutine(DelaySceneLoad("MissionComplete"));
    }

    public void ReplayGame()
    {
        StartCoroutine(DelaySceneLoad("MiniGameOne"));
    }

    IEnumerator DelaySceneLoad(string scene)
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scene);
    }
}
