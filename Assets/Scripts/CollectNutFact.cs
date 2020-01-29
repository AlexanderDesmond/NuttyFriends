using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectNutFact : MonoBehaviour
{
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = TapTheNutGame.almondTapped;
    }

    // Update is called once per frame
    void Update() { }

    public void ToNutFact()
    {
        if (score < 8)
        {
            StartCoroutine(DelaySceneLoad("Almond_Front"));
        }
        else
        {
            StartCoroutine(DelaySceneLoad("Walnut_Front"));
        }
    }

    IEnumerator DelaySceneLoad(string scene)
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scene);
    }
}
