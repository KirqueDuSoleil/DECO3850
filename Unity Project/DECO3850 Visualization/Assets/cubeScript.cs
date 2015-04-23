using UnityEngine;
using System.Collections;

public class cubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Changing the colour of the cube so that we can see it
		gameObject.GetComponent<Renderer>().material.color = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {

	}

	//This is called to rotate the cube left - not working yet
	public void RotateLeft(){
		Vector3 position = this.transform.position;
		transform.Rotate (Vector3.right, Time.deltaTime);
		transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
		Debug.Log ("OhYissroatel");
	}
	//This is called to rotate the cube right  - not working yet
	public void RotateRight(){
		Vector3 position = this.transform.position;
		//this.transform.Rotate (Vector3(.5, 0, 0));
		Debug.Log ("OhYissroatel");
	}
	//This is called to move the cube right
	public void MoveRight(){
		Vector3 position = this.transform.position;
		position.x++;
		this.transform.position = position;

	}
	//This is what is called to move the cube left
	public void MoveLeft(){
		Vector3 position = this.transform.position;
		position.x--;
		this.transform.position = position;
	}
}
