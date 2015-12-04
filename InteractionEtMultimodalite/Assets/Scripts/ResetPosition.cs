using UnityEngine;
using System.Collections;

public class ResetPosition : MonoBehaviour {

	private Vector3 startPosition;
	private Quaternion startRotation;

	void Start () {
		startPosition = transform.position;
		startRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R)) {
			transform.position = startPosition;
			transform.rotation = startRotation;
		}
	}
}
