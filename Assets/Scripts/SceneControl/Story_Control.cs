using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story_Control : MonoBehaviour
{
    public void ToStoryTwo()
    {
        //SceneManager.LoadScene("Story2");
        StartCoroutine(DelaySceneLoad("Story2"));
    }

    public void ToStoryThree()
    {
        //SceneManager.LoadScene("Story3");
        StartCoroutine(DelaySceneLoad("Story3"));
    }

    public void ToStoryFour()
    {
        //SceneManager.LoadScene("Story4");
        StartCoroutine(DelaySceneLoad("Story4"));
    }

    public void ToStoryFive()
    {
        //SceneManager.LoadScene("Story5");
        StartCoroutine(DelaySceneLoad("Story5"));
    }

    public void ToStorySix()
    {
        //SceneManager.LoadScene("Story6");
        StartCoroutine(DelaySceneLoad("Story6"));
    }

    public void ToStorySeven()
    {
        //SceneManager.LoadScene("Story7");
        StartCoroutine(DelaySceneLoad("Story7"));
    }

    public void ToStoryEight()
    {
        //SceneManager.LoadScene("Story8");
        StartCoroutine(DelaySceneLoad("Story8"));
    }

    public void ToStoryNine()
    {
        //SceneManager.LoadScene("Story9");
        StartCoroutine(DelaySceneLoad("Story9"));
    }

    public void ToStoryTen()
    {
        //SceneManager.LoadScene("Story10");
        StartCoroutine(DelaySceneLoad("Story10"));
    }

    public void ToStoryEleven()
    {
        //SceneManager.LoadScene("Story11");
        StartCoroutine(DelaySceneLoad("Story11"));
    }

    public void ToStoryTwelve()
    {
        //SceneManager.LoadScene("Story12");
        StartCoroutine(DelaySceneLoad("Story12"));
    }

    public void ToStoryThirteen()
    {
        //SceneManager.LoadScene("Story13");
        StartCoroutine(DelaySceneLoad("Story13"));
    }

    public void ToStoryFourteen()
    {
        //SceneManager.LoadScene("Story14");
        StartCoroutine(DelaySceneLoad("Story14"));
    }

    public void ToStoryFifteen()
    {
        //SceneManager.LoadScene("Story15");
        StartCoroutine(DelaySceneLoad("Story15"));
    }

    public void ToStorySixteen()
    {
        //SceneManager.LoadScene("Story16");
        StartCoroutine(DelaySceneLoad("Story16"));
    }

    public void ToStorySeventeen()
    {
        //SceneManager.LoadScene("Story17");
        StartCoroutine(DelaySceneLoad("Story17"));
    }

    public void ToEpilogueOne()
    {
        //SceneManager.LoadScene("Epilogue1");
        StartCoroutine(DelaySceneLoad("Epilogue1"));
    }

    public void Skip()
    {
        StartCoroutine(DelaySceneLoad("Epilogue1"));
    }

    IEnumerator DelaySceneLoad(string scene)
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scene);
    }
}
