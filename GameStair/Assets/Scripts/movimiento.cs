using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {


	public Rigidbody2D rigit;
	private StopDice stopdado;
	private Vector2 vector2;



	// Use this for initialization
	void Start () {
		rigit = GetComponent<Rigidbody2D>();
		stopdado = GetComponent<StopDice>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		int valor=stopdado.obtenerValor();

		if (valor != 0) {

			Debug.Log("entro");
			moverNave();

		}

		
	}
	public void moverNave()
	{
		//vector2 = new Vector2 (valor, 0);
		
		//rigit.MovePosition (rigit.position + vector2);
		//rigit.transform.position = vector2;
	}
}

