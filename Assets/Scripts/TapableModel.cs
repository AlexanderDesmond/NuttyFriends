using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapableModel : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    string btnName;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                btnName = hit.transform.name;

                switch (btnName)
                {
                    case "sporty_granny@Hip Hop Dancing":
                        SceneManager.LoadScene("Story_First");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
