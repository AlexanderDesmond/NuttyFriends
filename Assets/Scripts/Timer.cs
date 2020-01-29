using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeLeft = 30.0f;
    //public Text timerText;
    //public TextMeshProUGUI tmpText;

    // Timer Bar
    Image timerBar;
    public float maxTime = 120.0f;
    //float time;

    void Start()
    {
        //tmpText = FindObjectOfType<TextMeshProUGUI>();

        timerBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        //timerText.text = (timeLeft).ToString("0");
        //tmpText.SetText((timeLeft).ToString("0"));

        timerBar.fillAmount = timeLeft / maxTime;

        if (timeLeft < 0)
        {
            // Do something. ;)
        }
    }
}
