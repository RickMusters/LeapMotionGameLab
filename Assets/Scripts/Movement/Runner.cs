using UnityEngine;
using System.Collections;

public class Runner : MonoBehaviour {

    public float speed;
    public static float distanceTraveled;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        distanceTraveled = transform.localPosition.x;
	}
}
