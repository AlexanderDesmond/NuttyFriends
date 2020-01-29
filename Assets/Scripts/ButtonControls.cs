using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControls : MonoBehaviour
{
    public void StartBtn()
    {
        SceneManager.LoadScene("AgeConfirmation");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("MiniGameOne");
    }
}
