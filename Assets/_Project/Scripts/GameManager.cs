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
		"You have finished the simulation.\n\nClick the next arrow to go again.",
		"Charles Townshend was a British whig who had a strong interest in turnip farming, earning him the nickname 'Turnip'",
		"Townshend's four field crop rotation consisted of rotating wheat, turnip, barley, and clovers. Turnips and clovers would replenish lost nitrogen in the soil as well as serve as fodder for livestock."
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

		GoTo (nextScene);
	}

	public void GoTo(int n){
		// Change for next exhibit
		Camera.main.GetComponent<Skybox>().material = skyboxArray[n];
		GameObject.Find ("InfoText").GetComponent<Text> ().text = infoArray [n];

		SceneManager.LoadScene (n);
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
