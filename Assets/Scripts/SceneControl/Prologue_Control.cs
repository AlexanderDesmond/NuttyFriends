using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prologue_Control : MonoBehaviour
{
    public void ToPrologueTwo()
    {
        //SceneManager.LoadScene("Prologue2");
        StartCoroutine(DelaySceneLoad("Prologue2"));
    }

    public void ToPrologueThree()
    {
        //SceneManager.LoadScene("Prologue3");
        StartCoroutine(DelaySceneLoad("Prologue3"));
    }

    public void ToPrologueFour()
    {
        //SceneManager.LoadScene("Prologue4");
        StartCoroutine(DelaySceneLoad("Prologue4"));
    }

    public void ToPrologueFive()
    {
        //SceneManager.LoadScene("Prologue5");
        StartCoroutine(DelaySceneLoad("Prologue5"));
    }

    public void ToPrologueSix()
    {
        //SceneManager.LoadScene("Prologue6");
        StartCoroutine(DelaySceneLoad("Prologue6"));
    }

    public void ToPrologueSeven()
    {
        //SceneManager.LoadScene("Prologue7");
        StartCoroutine(DelaySceneLoad("Prologue7"));
    }

    public void ToPrologueEight()
    {
        //SceneManager.LoadScene("Prologue8");
        StartCoroutine(DelaySceneLoad("Prologue8"));
    }

    public void ToPrologueNine()
    {
        //SceneManager.LoadScene("Prologue9");
        StartCoroutine(DelaySceneLoad("Prologue9"));
    }

    public void ToPrologueTen()
    {
        //SceneManager.LoadScene("Prologue10");
        StartCoroutine(DelaySceneLoad("Prologue10"));
    }

    public void BeginStory()
    {
        //SceneManager.LoadScene("Story1");
        StartCoroutine(DelaySceneLoad("Story1"));
    }

    IEnumerator DelaySceneLoad(string scene)
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scene);
    }
}
