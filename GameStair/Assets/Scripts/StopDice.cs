using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class StopDice : MonoBehaviour {

	// Declare variables
	private bool isHeld;
	private int clicks;
	public Animator anim;
	public SpriteRenderer animacion;
	public int valor;


	void Start ()
	{
		clicks =0;
		anim = GetComponent<Animator>();
		animacion = GetComponent<SpriteRenderer>();
		valor = 0;

		
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			stop();
			obtenerValor();
			
		}
	}

	public void obtenerValor()
	{
		if (anim.speed == 0) {

			if(animacion.sprite.name.Equals("dado sf_0"))
			{
				valor=1;
				Debug.Log(valor);
			}
			if(animacion.sprite.name.Equals("dado sf_1"))
			{
				valor=2;
				Debug.Log(valor);
			}
			if(animacion.sprite.name.Equals("dado sf_2"))
			{
				valor=3;
				Debug.Log(valor);
			}
			if(animacion.sprite.name.Equals("dado sf_3"))
			{
				valor=4;
				Debug.Log(valor);
			}
			if(animacion.sprite.name.Equals("dado sf_4"))
			{
				valor=5;
				Debug.Log(valor);
			}
			if(animacion.sprite.name.Equals("dado sf_5"))
			{
				valor=6;
				Debug.Log(valor);
			}
		}
	}

	public void stop(){

		if (anim.speed > 0) {
		
			anim.speed = 0;
		} else {
			anim.speed=1;
		}


	}
	



}
