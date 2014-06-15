using UnityEngine;
using System.Collections;

public class FadeScript : MonoBehaviour {
    public float fadeSpeed = 1.9f;
	public static bool fadeBool = false;

    void Awake()
    {
        guiTexture.pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
    }

    void Update()
    {
		if(fadeBool)
		{
			StartTut();
		}
    }

    void FadeToClear()
    {
        guiTexture.color = Color.Lerp(guiTexture.color, Color.clear, fadeSpeed * Time.deltaTime);
    }

    void FadeToBlack()
    {
        guiTexture.color = Color.Lerp(guiTexture.color, Color.black, fadeSpeed * Time.deltaTime);
    }

    void StartTut()
    {
        FadeToClear();
        if (guiTexture.color.a <= 0.05f)
        {
            guiTexture.color = Color.clear;
            guiTexture.enabled = false;
        }

    }

}
