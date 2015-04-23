using UnityEngine;
using System.Collections;

public class scene3Script : MonoBehaviour {
	/*All this is instantiating the 'prefab' objects in the scene 
	like the plane.  In scene1, I created them in the editor thing
	but I though it would be best to have them created from the code at runtime.
	This scene so far only has a plane.
	*/
	public GameObject planePrefab;
	GameObject planeObject;

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
		planeObject.GetComponent<Renderer> ().material.color = Color.green;

		//Actually linking the variable 'holderScript' to the real script
		holderScript = staticHolder.GetComponent<staticHolderScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		//this ChangeSceneCheck function will be listening for the keys which 
		//are being used to change scenes.  You can look at the actual function
		//in staticHolderScript.cs
		holderScript.ChangeSceneCheck ();
	}
}
