using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NutFactControl : MonoBehaviour
{
    private int score;


    // Start is called before the first frame update
    void Start()
    {
        score = TapTheNutGame.almondTapped;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextNutFact()
    {
        if (score < 8)
        {
            StartCoroutine(DelaySceneLoad("Walnut_Front"));
        }
        else
        {
            StartCoroutine(DelaySceneLoad("Almond_Front"));
        }
    }

    IEnumerator DelaySceneLoad(string scene)
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scene);
    }
}
