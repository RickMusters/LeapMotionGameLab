using UnityEngine;
using System.Collections;

public class StartExplain : MonoBehaviour {

	public static bool startTut = false;


	void Update()
	{
		if(startTut)
		{
			Destroy(GameObject.FindWithTag("Text"));
			CreateExplainLevel();
			startTut = false;
		}
	}

	void CreateExplainLevel()
	{
		Instantiate(Resources.Load("TutPrefabs/TutExplain"),new Vector3(0,0,0),Quaternion.identity);
	}
}
