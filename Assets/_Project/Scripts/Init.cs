using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (GameObject.Find("CarryOver"));
		SceneManager.LoadScene ("main");
	}
}
