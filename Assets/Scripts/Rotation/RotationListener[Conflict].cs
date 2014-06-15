using UnityEngine;
using System.Collections;

public class RotationListener : MonoBehaviour {

	public int speed;
    public BoxCollider2D box;

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
		transform.Rotate(0, 0, -1 * speed);
        box.size = new Vector2(1, 2);
        
	}

	void RotateRight(){
		transform.Rotate(0, 0, 1 * speed);
        box.size = new Vector2(1, 2);
	}

    void Update()
    {
        box.size = new Vector2(1, 1);
    }
}
