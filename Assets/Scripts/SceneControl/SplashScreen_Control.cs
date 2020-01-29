using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen_Control : MonoBehaviour
{
    public void TapBtn()
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
