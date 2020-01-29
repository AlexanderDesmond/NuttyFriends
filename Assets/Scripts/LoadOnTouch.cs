using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnTouch : MonoBehaviour
{
    Scene currentScene;
    string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        var touch = Input.GetTouch(0);



        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (sceneName == "PostTutorial")
            {
                if (touch.position.x < Screen.width / 2)
                {
                    SceneManager.LoadScene("Tutorial1.75");
                }
                else if (touch.position.x > Screen.width / 2)
                {
                    SceneManager.LoadScene("MiniGameOne");
                }
            }
            else if (sceneName == "Tutorial0.5")
            {
                SceneManager.LoadScene("Tutorial0.75");
            }
            else if (sceneName == "Tutorial0.75")
            {
                SceneManager.LoadScene("Tutorial1");
            }
            else if (sceneName == "Tutorial1")
            {
                SceneManager.LoadScene("Tutorial1.5");
            }
            else if (sceneName == "Tutorial1.5")
            {
                SceneManager.LoadScene("Tutorial1.75");
            }
            else if (sceneName == "Tutorial1.75")
            {
                SceneManager.LoadScene("Tutorial2");
            }
            else if (sceneName == "Tutorial2")
            {
                SceneManager.LoadScene("Tutorial3");
            }
            else if (sceneName == "Tutorial3")
            {
                SceneManager.LoadScene("PostTutorial");
            }
            else if (sceneName == "NutFact_Almond")
            {
                SceneManager.LoadScene("MissionComplete");
            }
            else if (sceneName == "Almond_Front")
            {
                SceneManager.LoadScene("MissionComplete");
            }
            else if (sceneName == "Walnut_Front")
            {
                SceneManager.LoadScene("MissionComplete");
            }
        }
    }
}
