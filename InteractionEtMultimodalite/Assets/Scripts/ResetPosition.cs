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
	public void reset() {
		transform.position = startPosition;
		transform.rotation = startRotation;
	}
}
