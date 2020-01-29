using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Control : MonoBehaviour
{
    public void PlayGameBtn()
    {
        //SceneManager.LoadScene("Prologue1");
        StartCoroutine(DelaySceneLoad("Prologue1"));
    }

    public void LevelSelectBtn()
    {
        //SceneManager.LoadScene("LevelSelect");
        StartCoroutine(DelaySceneLoad("LevelSelect"));
    }

    public void BackToStartBtn()
    {
        //SceneManager.LoadScene("StartScreen");
        StartCoroutine(DelaySceneLoad("StartScreen"));
    }

    IEnumerator DelaySceneLoad(string scene)
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scene);
    }
}
