using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]
public class HoleBehaviour : MonoBehaviour {

	private CylinderBehaviour occupator = null;

	void OnTriggerEnter(Collider other) {
		//If the other collider is a cylinder, ...
		if(other.gameObject.GetComponent<CylinderBehaviour>() != null) {
			//If the hole is not occupied, ...
			if(occupator == null) {
				//The hole becomes occupied.
				occupator = other.gameObject.GetComponent<CylinderBehaviour>();
				//Bind position.
				occupator.hole = this;
			}
		}
	}

	void OnTriggerExit(Collider other) {
		//If the other is the occupator, ...
		if(occupator != null && occupator != other.gameObject.GetComponent<CylinderBehaviour>()) {
			//Unbind position.
			occupator.hole = null;
			//The hole no longer is occupied.
			occupator = null;
		}
	}

}
