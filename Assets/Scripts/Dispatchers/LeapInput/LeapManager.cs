using UnityEngine;
using System.Collections;
using Leap;

public class LeapManager : MonoBehaviour {

	public delegate void LeapAction();
	public static event LeapAction LeapHandLeft;
	public static event LeapAction LeapHandRight;
    public static event LeapAction LeapHandJump;
    public static event LeapAction LeapHandDash;

	private Controller controller = new Controller();

    void Start()
    {
        controller.EnableGesture(Gesture.GestureType.TYPESWIPE, true);
    }

	void Update(){

		Frame current = controller.Frame();

        GestureList gestures = current.Gestures();

        for (int i = 0; i < gestures.Count; i++)
        {
            Gesture gesture1 = gestures[1];
            switch (gesture1.Type)
            {
                case Gesture.GestureType.TYPESWIPE:
                    LeapHandJump();
                    break;                 
            }
           /* Gesture gesture2 = gestures[0];
            switch (gesture2.Type)
            {
                case Gesture.GestureType.TYPESWIPE:
                    LeapHandDash();
                    break;
            }*/
        }

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