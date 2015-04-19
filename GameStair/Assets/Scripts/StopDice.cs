using UnityEngine;
using System.Collections;

public class StopDice : MonoBehaviour {

	// Declare variables
	private bool isHeld;
	private int clicks;

	// Use this for initialization
	void Start ()
	{
		clicks = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (isHeld)
		{
			OnMouseDown();
		}else if (clicks > 1)
		{
			OnMouseUp();   
		}
	}
	
	// If player clicks egg, it is picked up
	void OnMouseDown ()
	{      
		Debug.Log("You're holding the egg!");
		clicks ++;
	}
	
	void OnMouseUp ()
	{
		isHeld = false;
		Debug.Log("You released the egg!");
		animation.stop();
	}

}
