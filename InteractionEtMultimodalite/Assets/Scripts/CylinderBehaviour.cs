using UnityEngine;
using System.Collections;

public class CylinderBehaviour : MonoBehaviour {

	[HideInInspector]
	public HoleBehaviour hole = null;
	
	private GameObject skin;

	// Use this for initialization
	void Awake() {
		skin = transform.GetChild(0).gameObject;
	}
	
	// Update is called once per frame
	void Update() {
		if(hole == null) {
			skin.transform.position = transform.position;
			skin.transform.rotation = transform.rotation;
		} else {
			skin.transform.position = hole.transform.position;
			skin.transform.rotation = hole.transform.rotation;
		}
	}
}
