using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceSpinner : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler (0, 90*Mathf.Sin (Time.time), 0);
	}
}
