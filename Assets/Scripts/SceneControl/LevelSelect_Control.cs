using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect_Control : MonoBehaviour
{
    public void BackToMenuBtn()
    {
        //SceneManager.LoadScene("Menu");
        StartCoroutine(DelaySceneLoad("Menu"));
    }

    IEnumerator DelaySceneLoad(string scene)
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scene);
    }
}
