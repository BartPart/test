using UnityEngine;
using System.Collections;

public class OnePlayer : MonoBehaviour {

	private int clicks;
	
	void Start ()
	{
		clicks = 0;
	}
	
	void Update ()
	{
		if (clicks > 1)
		{
			OnMouseUp();   
		}
	}
	
	void OnMouseUp ()
	{
		Application.LoadLevel ("FirstScene");
	}
}
