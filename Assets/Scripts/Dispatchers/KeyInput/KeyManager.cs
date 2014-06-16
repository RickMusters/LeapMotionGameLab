using UnityEngine;
using System.Collections;

public class KeyManager : MonoBehaviour {

	public delegate void KeyAction();
	public static event KeyAction keyPushedLeft;
	public static event KeyAction keyPushedRight;

	void Update(){

		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			if(keyPushedLeft != null)
			{
				keyPushedLeft();
			}
		}
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			if(keyPushedRight != null)
			{
				keyPushedRight();
			}
		}
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(0);
        }

	}
}
