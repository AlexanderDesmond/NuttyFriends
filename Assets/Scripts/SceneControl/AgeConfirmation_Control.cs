using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AgeConfirmation_Control : MonoBehaviour
{
    public void YesBtn()
    {
        //SceneManager.LoadScene("Menu");
        StartCoroutine(DelaySceneLoad("Menu"));
    }

    public void NoBtn()
    {
        //SceneManager.LoadScene("ParentConfirmation");
        StartCoroutine(DelaySceneLoad("ParentConfirmation"));
    }

    IEnumerator DelaySceneLoad(string scene)
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scene);
    }
}
