using UnityEngine;
using System.Collections;

public class TextFade : MonoBehaviour
{
    public float fadeSpeed;
    private bool fadeOut = true;
    private float sec = 50;
    

    void Update()
    {
        sec -=1;
        if (fadeOut)
        {
            FadeToClear();
            if (sec == 0)
            {
                fadeOut = false;
                sec = 50;
            }
        }
        else {
            FadeToWhite();
            if (sec == 0)
            {
                fadeOut = true;
                sec = 50;
            }
        }
    }

    void FadeToClear()
    {
        guiText.color = Color.Lerp(guiText.color, Color.clear, fadeSpeed * Time.deltaTime);
    }

    void FadeToWhite()
    {

        guiText.color = Color.Lerp(guiText.color, Color.white, fadeSpeed * Time.deltaTime);
    }
}