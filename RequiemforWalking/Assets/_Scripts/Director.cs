using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour {
	public Transform kyle;
	int count;

	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		count++;
		if (count > 15) {
			count = 0;
			Instantiate (kyle, new Vector3 (0, gameObject.GetComponent<Transform>().position.y - 5, 0), Quaternion.identity);
		}
	}
}
