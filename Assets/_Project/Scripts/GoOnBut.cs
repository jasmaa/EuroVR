using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoOnBut : MonoBehaviour {

	public Material highlight;
	public Material norm;

	public void GoOn(){
		GameManager.instance.GoNextScene ();
	}

	public void Highlight(){
		GetComponent<Renderer> ().material = highlight;
	}
	public void UnHighlight(){
		GetComponent<Renderer> ().material = norm;
	}
}
