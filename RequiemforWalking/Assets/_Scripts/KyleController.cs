using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyleController : MonoBehaviour {
	public Rigidbody head;
	public Rigidbody leftArm;
	public Rigidbody rightArm;
	public Rigidbody leftLeg;
	public Rigidbody rightLeg;
	public Rigidbody chest;

	public float baseIntensity;

	// Use this for initialization
	void Start () {
		baseIntensity = 2000;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			PushLimb (baseIntensity, head);
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			PushLimb (baseIntensity * -1, head);
		}
	}

	void PushLimb(float intensity, Rigidbody rb){
		rb.AddForce (intensity * rb.GetComponentInParent<Transform>().forward);
	}
		
}
