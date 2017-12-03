using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {

	public float xRot = 0;
	public float yRot = 1;
	public float zRot = 0;

	// Update is called once per frame
	void Update () {
		transform.Rotate (xRot, yRot, zRot);
	}
}
