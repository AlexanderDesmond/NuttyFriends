using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Epilogue_Control : MonoBehaviour
{
    public void ToEpilogueTwo()
    {
        //SceneManager.LoadScene("Epilogue2");
        StartCoroutine(DelaySceneLoad("Epilogue2"));
    }

    public void ToEpilogueThree()
    {
        //SceneManager.LoadScene("Epilogue3");
        StartCoroutine(DelaySceneLoad("Epilogue3"));
    }

    public void TutorialStory()
    {
        //SceneManager.LoadScene("Tutorial0.5");
        StartCoroutine(DelaySceneLoad("Tutorial0.5"));
    }

    public void LoadTutorial()
    {
        //SceneManager.LoadScene("Tutorial1");
        StartCoroutine(DelaySceneLoad("Tutorial1"));
    }

    public void Another()
    {
        StartCoroutine(DelaySceneLoad("Tutorial1.5"));
    }

    public void YetAnother()
    {
        StartCoroutine(DelaySceneLoad("Tutorial1.75"));
    }

    public void ContinueTutorial()
    {
        //SceneManager.LoadScene("Tutorial2");
        StartCoroutine(DelaySceneLoad("Tutorial2"));
    }

    public void AnotherTutorialScreen()
    {
        //SceneManager.LoadScene("Tutorial2");
        StartCoroutine(DelaySceneLoad("Tutorial3"));
    }

    public void EndTutorial()
    {
        StartCoroutine(DelaySceneLoad("PostTutorial"));
    }

    public void PlayGame()
    {
        //SceneManager.LoadScene("MiniGameOne");
        StartCoroutine(DelaySceneLoad("MiniGameOne"));
    }

    IEnumerator DelaySceneLoad(string scene)
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scene);
    }
}
