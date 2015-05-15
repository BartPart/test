using UnityEngine;
using System.Collections;

public class MenuPausa : MonoBehaviour {

	// Declare variables
	private int clicks;
	private bool pausa;
	
	// Use this for initialization
	void Start ()
	{
		clicks = 0;
		pausa = false;
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
		if (pausa == false) {
			pausa = true;
			Time.timeScale = 0;
		} else {
			pausa=false;
			Time.timeScale=1;
		}
	}
}
