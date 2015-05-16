using UnityEngine;
using System.Collections;

public class piso : MonoBehaviour {

	public int c1=0;


	public piso(){
	}

	// Use this for initialization
	void Start () {
		OnGUI ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setNum (int cas1)
	{
		this.c1 = cas1;
		Debug.Log ("valorc1"+c1);

	}

	public int getNum()
	{
		return c1;
	}

	void OnGUI () {

		GUIStyle style = new GUIStyle ();
		style.font = (Font)Resources.Load ("Squimpy", typeof(Font));
		style.fontSize = 100;
		style.normal.textColor = Color.black;

		GUI.Label (new Rect (800, 780, 225, 25), c1+"", style);
	}

}
