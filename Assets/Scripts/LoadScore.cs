using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScore : MonoBehaviour
{
    //public TextMeshProUGUI scoreText;
    //public TextMeshProUGUI timeText;


    Text scoreText;

    public int score;
    //public float time;

    // Start is called before the first frame update
    void Start()
    {
        score = TapTheNutGame.almondTapped;
        //time = TapTheNutGame.timeLeft;
        //scoreText.SetText("Score: " + count.ToString());
        //timeText.SetText("Time: " + (60 - time).ToString("0"));

        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("MiniGameOne");
    }
}
