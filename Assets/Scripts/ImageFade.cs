using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageFade : MonoBehaviour
{
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        image.canvasRenderer.SetAlpha(0.0F);
        FadeIn();

        StartCoroutine(LoadMiniGameOne());
    }

    void FadeIn()
    {
        image.CrossFadeAlpha(1.0F, 5f, false);
    }

    void FadeOut()
    {
        image.CrossFadeAlpha(0.0F, 2.5f, false);
    }

    // Just to get a screen to load manually for the moment.
    IEnumerator LoadMiniGameOne()
    {
        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("MiniGameOne");
    }
}
