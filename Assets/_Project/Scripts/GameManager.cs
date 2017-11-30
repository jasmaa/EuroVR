using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	Image fadeScreen;

	string[] infoArray = {
		"",
		"This is AP Euro",
		"Charles Townshend was a British whig who had a strong interest in turnip farming, earning him the nickname 'Turnip'",
		"placeholder",
	};
	public Material[]  skyboxArray;

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

		int nextScene = (SceneManager.GetActiveScene ().buildIndex) % (SceneManager.sceneCountInBuildSettings - 1) + 1;

		// Change for next exhibit
		Camera.main.GetComponent<Skybox>().material = skyboxArray[nextScene];
		GameObject.Find ("InfoText").GetComponent<Text> ().text = infoArray [nextScene];

		SceneManager.LoadScene (nextScene);
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
