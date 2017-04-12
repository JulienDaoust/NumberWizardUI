using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log("LoadLevel request: " + name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest() {
		Debug.Log("QuitLevelRequest: ");
		Application.Quit();
	}

}
