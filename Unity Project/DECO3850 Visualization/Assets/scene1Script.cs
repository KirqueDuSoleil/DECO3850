using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class scene1Script : MonoBehaviour {
	/*These two lines are setting up access to the script which holds the
	 * functions which we will use in more than one scene so that we don't
	 * have to repeat them
	 * */
	public GameObject staticHolder;
	public staticHolderScript holderScript;


	public GameObject cubePrefab;
	GameObject cube;
	cubeScript cubeScript;

	// Use this for initialization
	void Start () {
		//Actually linking the variable 'holderScript' to the real script
		holderScript = staticHolder.GetComponent<staticHolderScript> ();


		//Getting the cube to show up in the scene
		cube = (GameObject)Instantiate (cubePrefab, new Vector3 (0, 0, 0), Quaternion.identity);

		//Getting access to the functions inside the cubeScript.cs class
		cubeScript = cube.GetComponent<cubeScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		//this ChangeSceneCheck function will be listening for the keys which 
		//are being used to change scenes.  You can look at the actual function
		//in staticHolderScript.cs
		holderScript.ChangeSceneCheck ();

		//This is handling the cube moving stuff
		
		//If the right arrow is pressed, the function which handles right rotation is called
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			cubeScript.MoveRight();
		}
		//As above, but with left
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			cubeScript.MoveLeft();
		}
	}


}
