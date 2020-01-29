using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TapTheNutGame : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    string objName;

    // Game logic properties!!!
    public static float timeLeft;
    public static int count;
    public static int almondTapped = 0;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI counterText;


    void Start()
    {
        timeLeft = 120.0f;
        count = 0;
        //audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Keep track of and display time remaining
        timeLeft -= Time.deltaTime;
        timerText.SetText((timeLeft / 2).ToString("0"));
        if (timeLeft < 0 || almondTapped == 10)
        {
            SceneManager.LoadScene("Score");
        }

        // Keep track of score
        counterText.SetText((count).ToString("0"));

        // Handle the tapping of nuts
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                objName = hit.transform.name;

                switch (objName)
                {
                    case "almond":
                        TapAlmond();
                        GameObject.Find(objName).SetActive(false);
                        break;
                    case "almond (1)":
                        TapAlmond();
                        GameObject.Find(objName).SetActive(false);
                        break;
                    case "almond (2)":
                        TapAlmond();
                        GameObject.Find(objName).SetActive(false);
                        break;
                    case "almond (3)":
                        TapAlmond();
                        GameObject.Find(objName).SetActive(false);
                        break;
                    case "almond (4)":
                        TapAlmond();
                        GameObject.Find(objName).SetActive(false);
                        break;
                    case "almond (5)":
                        TapAlmond();
                        GameObject.Find(objName).SetActive(false);
                        break;
                    case "almond (6)":
                        TapAlmond();
                        GameObject.Find(objName).SetActive(false);
                        break;
                    case "almond (7)":
                        TapAlmond();
                        GameObject.Find(objName).SetActive(false);
                        break;
                    case "almond (8)":
                        TapAlmond();
                        GameObject.Find(objName).SetActive(false);
                        break;
                    case "almond (9)":
                        TapAlmond();
                        GameObject.Find(objName).SetActive(false);
                        break;
                    case "acorn":
                        TapAcorn();
                        break;
                    case "acorn (1)":
                        TapAcorn();
                        break;
                    case "acorn (2)":
                        TapAcorn();
                        break;
                    case "acorn (3)":
                        TapAcorn();
                        break;
                    case "acorn (4)":
                        TapAcorn();
                        break;
                    default:
                        break;
                }
            }
        }
    }

    // Handle tapping of almonds.
    void TapAlmond()
    {
        ++count;
        ++almondTapped;
        PlayClip(0);
    }

    // Handle tapping of acorns.
    void TapAcorn()
    {
        --count;
        PlayClip(1);
    }

    // Handle playing of sound effect when a nut is tapped.
    void PlayClip(int position)
    {
        audioSource.clip = audioClips[position];
        audioSource.PlayOneShot(audioSource.clip);

        //audioSource.Play();
    }
}
