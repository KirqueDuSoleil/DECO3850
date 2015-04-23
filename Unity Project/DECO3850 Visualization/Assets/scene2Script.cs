using UnityEngine;
using System.Collections;

public class scene2Script : MonoBehaviour {
	/*All this gunk is instantiating the 'prefab' objects in the scene 
	like the plane and cube.  In scene1, I created them in the editor thing
	but I though it would be best to have them created from the code at runtime.
	*/
	public GameObject planePrefab;
	GameObject planeObject;
	public GameObject cubePrefab;
	GameObject cube;
	cubeScript cubeScript;

	/*These two lines are setting up access to the script which holds the
	 * functions which we will use in more than one scene so that we don't
	 * have to repeat them
	 * */
	public GameObject staticHolder;
	public staticHolderScript holderScript;

	// Use this for initialization
	void Start () {
		//Getting the plane (which i'm using as a background) to show up in the scene
		planeObject = (GameObject)Instantiate (planePrefab, new Vector3 (0, 0, 0), Quaternion.identity);
		//Changing its colour
		planeObject.GetComponent<Renderer>().material.color = Color.red;

		//Getting the cube to show up in the scene
		cube = (GameObject)Instantiate (cubePrefab, new Vector3 (0, 0, 0), Quaternion.identity);

		//Actually linking the variable 'holderScript' to the real script
		holderScript = staticHolder.GetComponent<staticHolderScript> ();

		//Getting access to the functions inside the cubeScript.cs class
		cubeScript = cube.GetComponent<cubeScript> ();


	}
	
	// Update is called once per frame
	void Update () {
		//This is handling the rotation stuff

		//If the right arrow is pressed, the function which handles right rotation is called
		if (Input.GetKeyDown(KeyCode.RightArrow))
		   {
			cubeScript.RotateRight();
		}
		//As above, but with left
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			cubeScript.RotateLeft();
		}

		//this ChangeSceneCheck function will be listening for the keys which 
		//are being used to change scenes.  You can look at the actual function
		//in staticHolderScript.cs
		holderScript.ChangeSceneCheck ();
	}
}
