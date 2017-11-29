using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	Image fadeScreen;

	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
		} else {
			Destroy (gameObject);
		}

		fadeScreen = GameObject.Find ("FadeScreen").GetComponent<Image>();
	}
	
	public void GoNextScene(){
		FadeFromBlack ();
		SceneManager.LoadScene ((SceneManager.GetActiveScene().buildIndex) % (SceneManager.sceneCountInBuildSettings - 1) + 1);
	}
	
	public void FadeToBlack(){
			fadeScreen.color = Color.black;
			fadeScreen.canvasRenderer.SetAlpha (0.0f);
			fadeScreen.CrossFadeAlpha(1.0f, 0.5f, false);
	}
	public void FadeFromBlack(){
		fadeScreen.color = Color.black;
		fadeScreen.canvasRenderer.SetAlpha (1.0f);
		fadeScreen.CrossFadeAlpha(0.0f, 0.5f, false);
	}
}
