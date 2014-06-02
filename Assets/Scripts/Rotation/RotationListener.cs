using UnityEngine;
using System.Collections;

public class RotationListener : MonoBehaviour {

	public int speed;

	void OnEnable(){

		KeyManager.keyPushedLeft += RotateLeft;
		KeyManager.keyPushedRight += RotateRight;
		LeapManager.LeapHandLeft += RotateLeft;
		LeapManager.LeapHandRight += RotateRight;
	}

	void OnDisable(){

		KeyManager.keyPushedLeft -= RotateLeft;
		KeyManager.keyPushedRight -= RotateRight;
		LeapManager.LeapHandLeft -= RotateLeft;
		LeapManager.LeapHandRight -= RotateRight;
	}

	void RotateLeft(){

		transform.Rotate(new Vector3(0,0,1 *- speed));
	}

	void RotateRight(){

		transform.Rotate(new Vector3(0,0,1 * speed));
	}
}
