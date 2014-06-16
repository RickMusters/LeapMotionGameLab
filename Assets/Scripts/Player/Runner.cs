using UnityEngine;
using System.Collections;

public class Runner : MonoBehaviour {

    public static float distanceTraveled;

    void OnEnable()
    {
        LeapManager.LeapHandJump += Jump;
        LeapManager.LeapHandDash += Dash;
    }

    void OnDisable()
    {
        LeapManager.LeapHandJump -= Jump;
        LeapManager.LeapHandDash -= Dash;
    }

    void Update()
    {
        transform.Translate(5f * Time.deltaTime, 0f, 0f);
        distanceTraveled = transform.localPosition.x;
    }

    private void Jump()
    {
        transform.Translate(0, 1, 0);
    }

    private void Dash()
    {
        transform.Translate(10, 0, 0);
    }
}
