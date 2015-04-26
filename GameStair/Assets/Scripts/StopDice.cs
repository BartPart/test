using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class StopDice : MonoBehaviour {

	// Declare variables
	private bool isHeld;
	private int clicks;
	public Animation anim;


	void Start ()
	{
		clicks =0;
		anim = GetComponent<Animation>();

		
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			OnMouseUp();
			stop();
		}
	}

	void OnMouseUp ()
	{


	}

	public void stop(){

		anim.Stop();


	}
	



}
