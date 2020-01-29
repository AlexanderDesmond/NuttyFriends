using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParentConfirmation_Control : MonoBehaviour
{
    public void TapBtn()
    {
        //SceneManager.LoadScene("NutAllergyQuestion");
        StartCoroutine(DelaySceneLoad("NutAllergyQuestion"));
    }

    IEnumerator DelaySceneLoad(string scene)
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scene);
    }
}
