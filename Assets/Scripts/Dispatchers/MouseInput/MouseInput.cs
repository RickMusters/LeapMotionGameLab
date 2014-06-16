using UnityEngine;
using System.Collections;

public class MouseInput : MonoBehaviour {

	void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "Endless")
                {
                    Application.LoadLevel(3);
                }
                if (hit.collider.name == "Rotation")
                {
                    Application.LoadLevel(1);
                }
            }
        }
	}
}
