using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen_Control : MonoBehaviour
{
    public void StartBtn()
    {
        //SceneManager.LoadScene("AgeConfirmation");
        StartCoroutine(DelaySceneLoad("AgeConfirmation"));
    }

    IEnumerator DelaySceneLoad(string scene)
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scene);
    }
}
