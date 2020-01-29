using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NutAllergyPrecaution_Control : MonoBehaviour
{
    public void ToMenuBtn()
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
