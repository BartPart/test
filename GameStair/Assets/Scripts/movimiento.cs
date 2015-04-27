using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {

	public float maxSpeed = 10f;
	public Vector2 velocity;
	bool facingRight = true;
	StopDice scriptDice;

	// Use this for initialization
	void Start () {

		scriptDice = GetComponent<StopDice>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {



		if (scriptDice.anim.speed == 0) {

			int valorMov=scriptDice.valor;
			Debug.Log ("entro al update");
			float move = Input.GetAxis ("Horizontal");
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * valorMov, GetComponent<Rigidbody2D> ().velocity.y);
			
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

	}
}
