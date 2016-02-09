using UnityEngine;
using System.Collections;

public class FalconBehaviour : MonoBehaviour {

    [SerializeField]
    private SphereManipulator falcon;

    private CylinderBehaviour cylinder = null;
	
	// Update is called once per frame
	void Update () {
	    if(cylinder != null) {
            if(falcon.button_states[0]) {
                cylinder.transform.position = transform.position;
            }
        }
	}

    void OnTriggerEnter(Collider other) {
        if(other.tag.Equals("Cylinder") && cylinder == null) {
            cylinder = other.transform.parent.GetComponent<CylinderBehaviour>();
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.tag.Equals("Cylinder"))
        {
            CylinderBehaviour cb = other.transform.parent.GetComponent<CylinderBehaviour>();
            if(cb == cylinder) {
                cylinder = null;
            }
        }
    }

}
