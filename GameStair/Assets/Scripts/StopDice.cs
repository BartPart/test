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
		if (clicks > 1)
		{
			OnMouseUp();   
		}
	}
	

	
	void OnMouseUp ()
	{
		isHeld = false;
		Debug.Log("Usted toco el dado!");
		//animation.stop();
	}

}
