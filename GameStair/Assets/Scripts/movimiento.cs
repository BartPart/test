using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {

	public float maxSpeed = 10f;
	public Vector2 velocity;
	bool facingRight = true;
	StopDice scriptDice;
	Rigidbody2D rigit;


	// Use this for initialization
	void Start () {

		scriptDice = GetComponent<StopDice>();
		rigit = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void fixedUpdate () {

		int valorMov = scriptDice.valor;




		if (valorMov != 1) {
			Debug.Log("antes del rigit");
			rigit.AddForce (new Vector2(valorMov, 0));

			//float move = Input.GetAxis ("Horizontal");

			/*
			int valorMov=scriptDice.valor;
			Debug.Log ("entro al update");

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * valorMov, GetComponent<Rigidbody2D> ().velocity.y);


			Debug.Log("paro el dado");
			
			if (move > 0 && !facingRight)
				flip ();
			else if (move < 0 && facingRight)
				flip ();
		} else {
			Debug.Log("no entro");
		}

	}

	void flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;

	}*/
		
}
	}
}
