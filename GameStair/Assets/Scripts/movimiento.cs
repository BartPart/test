using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {


	public Rigidbody2D rigit;

	private Vector2 vector2;
	private int valor;
	public StopDice dice;




	// Use this for initialization
	void Start () {
		rigit = GetComponent<Rigidbody2D>();
		//dice = GameObject.FindGameObjectWithTag ("dado").GetComponent<StopDice> ();


	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		//valor = dice.obtenerValor ();


		moverNave () ;

	}
	public void moverNave()
	{
		valor = dice.valor;

		if(valor!=0){

		}
		print (valor);
		int valorMovimiento = valor;
		vector2 = new Vector2 (valorMovimiento, 0);

		//rigit.velocity = 5;
		//rigit.MovePosition (rigit.position + vector2);
		rigit.MovePosition (rigit.position+vector2);

	}
	
}

