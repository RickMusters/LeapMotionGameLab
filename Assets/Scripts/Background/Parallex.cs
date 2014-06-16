using UnityEngine;
using System.Collections;

public class Parallex : MonoBehaviour {

    public float scrollspeed = 0.5f;

    void Update()
    {

        renderer.material.mainTextureOffset = new Vector2(Time.time * scrollspeed, 0f);

    }
}
