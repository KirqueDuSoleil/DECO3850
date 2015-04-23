using UnityEngine;
using System.Collections;

public class staticHolderScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/*Listens for key presses to change scenes,
	 * it's called by the main scripts in each scene in their Update function*/
	public void ChangeSceneCheck(){
		if (Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log ("Scene1 Pressed");
			ChangeScene(1);
		}
		if (Input.GetKeyDown (KeyCode.B)) {
			Debug.Log ("Scene2 Pressed");
			ChangeScene(2);
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			Debug.Log ("Scene3 Pressed");
			ChangeScene(3);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			Debug.Log ("Scene4 Pressed");
			ChangeScene(4);
		}
	}
	/*Actually changes the scene*/
	int ChangeScene(int sceneNum){
		string sceneName = "scene" + sceneNum;
		Application.LoadLevel (sceneName);
		Debug.Log ("Yeahyeahboi");
		return 1;
	}
}
