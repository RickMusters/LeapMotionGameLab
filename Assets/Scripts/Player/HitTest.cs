using UnityEngine;
using System.Collections;

public class HitTest : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.collider2D.tag == "EndGame")
        {
            Application.LoadLevel(0);
        }
    }
}
