/*
	* Developers: poppmintt & srcerer17
	* Date: 12.09.2018
	* Program: PlayerController.cs
	* Script Version: V1 p
	* Purpose: Handles the movement of the Player object
*/

/*
	Notes:
		Coding notes:
			#f means that the number # is a float, once the f is added

		Just finished this episode:
			https://www.youtube.com/watch?v=Oao-A7bkve0

		To Do:
			Add annimations facing the direction the player has stopped.
*/

// Import Unity Packages
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour 
{

	// Creates global variables
	public float moveSpeed = 3;
	private Animator anim;

	// initialization
	void Start () 
	{
		// Assigns anim to the player animator
		anim = GetComponent<Animator>(); 
	}
	
	// Update is called once per frame
	void Update () 
	{
		// If our input on the horizontal axis is moving right OR if our isput is moving left
		if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f )
		{
			// Move. (Minipulate the x axis, not the y or z axis)
			transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f ));
		}


		// If our input on the vertical axis is moving up OR if our isput is moving down
		if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f )
		{
			// Move. (Minipulate the y axis, not the x or z axis)
			transform.Translate (new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f ));
		}

		// Updates the animator
		anim.SetFloat("Move X", Input.GetAxisRaw("Horizontal"));
		anim.SetFloat("Move Y", Input.GetAxisRaw("Vertical"));
	}
}
