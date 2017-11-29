using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoOnBut : MonoBehaviour {

	public void GoOn(){
		GameManager.instance.GoNextScene ();
	}
}
