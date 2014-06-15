using UnityEngine;
using System.Collections;
using Leap;

public class LeapManager : MonoBehaviour {

	public delegate void LeapAction();
	public static event LeapAction LeapHandLeft;
	public static event LeapAction LeapHandRight;

	private Controller controller = new Controller();

	void Update(){

		Frame current = controller.Frame();
		float roll = current.Hands[0].PalmNormal.Roll;

		if(current.Hands.Count == 1)
		{
			if(!StartExplain.explainSpawned)
			{
				StartExplain.startTut = true;
			}
		}

		if(roll > 0.3f & roll < 2.8)
		{
			if(LeapHandLeft != null)
			{
				LeapHandRight();
			}
		}

		if(roll < -0.3f & roll > -2.8)
		{
			if(LeapHandRight != null)
			{
				LeapHandLeft();
			}
		}
	}
}