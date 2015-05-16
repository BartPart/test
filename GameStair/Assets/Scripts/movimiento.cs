using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class movimiento : MonoBehaviour {

	public Animator anim;
	public SpriteRenderer animacion;
	public Rigidbody2D rigit;
	public int c1=0;
	private StopDice stopdado;
	private Vector2 vector2;
	public listaPreguntas quest;
	List<pregunta> p = new List<pregunta>();
	List<int> trap = new List<int> ();
	public Rect windowRect = new Rect (0, 0, 0, 0);
	public bool doWindow0 = false;
	public string enunciado="";
	private int click;
	pregunta help;
	public Rect windowWarn= new Rect (0, 0, 0, 0);
	public Rect windowWarnB= new Rect (0, 0, 0, 0);
	public Rect windowLb= new Rect (0, 0, 0, 0);
	public string warning="";
	public string warningB ="";
	public string ms1 ="";
	public string q1="";
	public string q2="";
	public string q3="";
	public string q4="";
	public string q5="";

	int index=0;

	int a=0;
	int b=0;
	int c=0;
	int d=0;
	int e=0;
	int f=0;
	int g=0;

	/*int a = 50;
	int b = 50;
	int c = 150;
	int d = 50;
	int e = 330; 
	int f = 150;
	int g = 250;*/

	int w1=0;
	int w2=0;
	int w3=0;
	int w4=0;

	// Use this for initialization
	void Start () {
		//rigit = GetComponent<Rigidbody2D>();
		//floor = new piso ();
		quest = new listaPreguntas ();
		quest.questions();
		quest.casillasPreguntas ();
		p = quest.getTrivia ();
		trap = quest.getPreg();
		click = 0;

	}
	
	// Update is called once per frame
	void FixedUpdate()
	{

		if (click > 1)
		{
			OnMouseUp();
		}

	}
	void OnMouseUp()
	{
		startDice();
		
		//Debug.Log ("preguntas" + p.Count);
		
		int valor = obtenerValor();
		
		//floor = new piso();
		//moverNave(valor);
		
		//Debug.Log("entra"+valor + " "+c1);
		c1 = c1+valor;
		//Debug.Log("entra2"+c1);
		comprobarQ(c1);
	}

	public void comprobarQ(int valor)
	{
		foreach (int aux in trap)
		{
			if(aux == valor)
			{
				index = Random.Range (0, (p.Count));

				help = p[index];

				quest.formato(help.getQuestion(), index);

				a = quest.getA();
				b = quest.getB();
				c = quest.getC();
				d = quest.getD();
				e = quest.getE();
				f = quest.getF();
				g = quest.getG();

				w1 = quest.getW1();
				w2 = quest.getW2();
				w3 = quest.getW3();
				w4 = quest.getW4();

				/*w1=320; 
				w2=70; 
				w3=780; 
				w4=650;*/
				/*
				 * 		windowWarn= new Rect (200, 520, 300, 30);
						windowWarnB= new Rect (320, 570, 100, 30);*/

				//Debug.Log(a+"a"+b+"b"+c+"c"+d+"d"+e+"e"+f+"f"+g+"" + w1+"w1"+w2+"w2"+w3+"w3"+w4+"w4");

				enunciado = help.getId()+". "+help.getQuestion();
				doWindow0 = true;
				windowRect = new Rect(w1, w2, w3, w4);

			}
		}

	}
	/*
	public void moverNave(int valor)
	{
		int valorMovimiento = valor + valor + valor+ valor+ valor+ valor;
		vector2 = new Vector2 (valorMovimiento, 0);
		
		rigit.MovePosition (rigit.position + vector2);

	}*/

	public int obtenerValor()
	{
		if (anim.speed == 0) {
			
			if (animacion.sprite.name.Equals ("dado sf_0")) {
				return 1;
			}
			if (animacion.sprite.name.Equals ("dado sf_1")) {
				return 2;
				
			}
			if (animacion.sprite.name.Equals ("dado sf_2")) {
				return 3;
				
			}
			if (animacion.sprite.name.Equals ("dado sf_3")) {
				return 4;
				
			}
			if (animacion.sprite.name.Equals ("dado sf_4")) {
				return 5;
				
			}
			if (animacion.sprite.name.Equals ("dado sf_5")) {
				return 6;
				
			}
			return 0;
		} else {
			return 0;
		}
	}
	public void startDice(){
		
		if (anim.speed == 1) {
			
			anim.speed = 0;
			
		} else {
			
			anim.speed = 1;
		}
	}

	public void answer(int resp, int numq)
	{
		Debug.Log ("resp: "+resp);
		int k = 0;
		int l = 0;
		if(numq==1 || numq==2)
		{
			k = b+70;
			l = b+110;
		}
		if(numq==3 || numq==4)
		{
			k = f+70;
			l = f+110;
		}
		if(numq==5)
		{
			k = g+70;
			l = g+110;
		}

		if(help.getResp ()==1)
		{
			Debug.Log ("entra1");
			//doWindow0=false;
			windowRect=new Rect (0, 0, 0, 0);
			//windowLb= new Rect (0, 0, 0, 0);
			//windowLb=new Rect (w1, w2, w3, w4);
			GUI.TextField (new Rect (20, 170, 250, 30), "Ingrese la segunda opción de respuesta:");
			//GUI.Label (new Rect (a, b, c, d), q1);
			//string text = GUI.TextField (new Rect (e, b, c, d), q2);

		}
		else{
			if(help.getResp ()==2)
			{
				Debug.Log ("entra2");
				//doWindow0=false;
				windowRect=new Rect (0, 0, 0, 0);
				//windowLb= new Rect (0, 0, 0, 0);
				//windowLb=new Rect (w1, w2, w3, w4);
				GUI.TextField (new Rect (20, 170, 250, 30), "Ingrese la segunda opción de respuesta:");
				//GUI.Label (new Rect (a, b, c, d), q1);
				//string text = GUI.TextField (new Rect (e, b, c, d), q2);
			}
			else{
				if(help.getResp ()==3)
				{
					Debug.Log ("entra3");
					//doWindow0=false;
					windowRect=new Rect (0, 0, 0, 0);
					//windowLb= new Rect (0, 0, 0, 0);
					//windowLb=new Rect (w1, w2, w3, w4);
					GUI.TextField (new Rect (20, 170, 250, 30), "Ingrese la segunda opción de respuesta:");
					//GUI.Label (new Rect (a, b, c, d), q1);
					//string text = GUI.TextField (new Rect (e, b, c, d), q2);

				}
				else{
					if(help.getResp ()==4)
					{
						Debug.Log ("entra4");
						//doWindow0=false;
						windowRect=new Rect (0, 0, 0, 0);
						//windowLb= new Rect (0, 0, 0, 0);
						//windowLb=new Rect (w1, w2, w3, w4);
						GUI.TextField (new Rect (20, 170, 250, 30), "Ingrese la segunda opción de respuesta:");
						//GUI.Label (new Rect (a, b, c, d), q1);
						//string text = GUI.TextField (new Rect (e, b, c, d), q2);
					}
					else{
						Debug.Log ("entra5");
						//doWindow0=false;
						windowRect=new Rect (0, 0, 0, 0);
						//windowLb= new Rect (0, 0, 0, 0);
						//windowLb=new Rect (w1, w2, w3, w4);
						GUI.TextField (new Rect (20, 170, 250, 30), "Ingrese la segunda opción de respuesta:");
						//GUI.Label (new Rect (a, b, c, d), q1);
						//string text = GUI.TextField (new Rect (e, b, c, d), q2);
					}
				}
			}

		}
		/*
		if (resp == help.getResp ()) {
			ms1 = "¡Haz acertado la pregunta! :D";
			warningB ="Aceptar";
			windowWarn=new Rect (0, 0, 0, 0);
			windowWarnB=new Rect (0, 0, 0, 0);
			windowWarn= new Rect (a, k, 300, 30);
			windowWarnB= new Rect (a, l, 100, 30);
		} else {
			ms1 = "No haz acertado la pregunta :(, la respuesta correcta era la #"+help.getResp ();
			warningB ="Aceptar";
			windowWarn=new Rect (0, 0, 0, 0);
			windowWarnB=new Rect (0, 0, 0, 0);
			windowWarn= new Rect (a, k, 380, 30);
			windowWarnB= new Rect (a, l, 100, 30);
		}*/
	}

	public int contarOp(string q1,string q2,string q3,string q4,string q5)
	{
		int cont = 0;

		if(q1!=null)
		{
			cont++;
		}
		if(q2!=null)
		{
			cont++;
		}
		if(q3!=null)
		{
			cont++;
		}
		if(q4!=null)
		{
			cont++;
		}
		if(q5!=null)
		{
			cont++;
		}

		return cont;
	}

	public void DoMyWindow(int windowID) {
		
		q1=p[index].getResp1();
		q2=p[index].getResp2();
		q3=p[index].getResp3();
		q4=p[index].getResp4();
		q5=p[index].getResp5();
		int resp = 0;
		int numop = contarOp(q1,q2,q3,q4,q5);
		Debug.Log (numop);

			//string[] options = new string[] {q1, q2, q3, q4};
			
			//if (GUI.Button(new Rect(10, 20, 100, 20), q1)) 
			if (q1 != null) {
			windowLb= new Rect (a, b, c, d);
			if (GUI.Button (windowLb, q1))
			{
				//Debug.Log(1);//
				answer (1,numop);
			}
		}

			if (q2 != null) {
			if(GUI.Button (new Rect (e, b, c, d), q2))
			{
				//Debug.Log(2);//
				answer (2,numop);
			}
		}

			if (q3 != null) {
			if(GUI.Button (new Rect (a, f, c, d), q3))
			{
				//Debug.Log(3);//
				answer (3,numop);
			}
		}

			if (q4 != null) {
			if(GUI.Button (new Rect (e, f, c, d), q4))
			{
				//Debug.Log(4);//
				answer (4,numop);
			}
		}

			
			if (q5 != null) {
			if(GUI.Button (new Rect (g, e, c, d), q5))
			{
				//Debug.Log(5);//
				answer (5,numop);
			}
		}

		warning = GUI.TextField ( windowWarn, ms1);
		
		if (GUI.Button (windowWarnB, warningB)) {
			
			ms1 = "";
			warningB = "";
			windowWarn = new Rect (0, 0, 0, 0);
			windowWarnB = new Rect (0, 0, 0, 0);

			q2="";
			q3="";
			q4="";
			q5="";

		}
				

	}
	

	void OnGUI () {
		
		GUIStyle style = new GUIStyle ();
		style.font = (Font)Resources.Load ("Squimpy", typeof(Font));
		style.fontSize = 100;
		style.normal.textColor = Color.black;
		
		GUI.Label (new Rect (800, 780, 225, 25), c1+"", style);

		if(doWindow0 == true)
		{
			windowRect=GUI.Window(0, windowRect, DoMyWindow,enunciado);
		}
	}
}

