using UnityEngine;
using System.Collections;

public class preguntaCreate : MonoBehaviour {

	string pregunta = ""; 
	string op1 = "";
	string op2 = "";
	string op3 = "";
	string op4 = "";
	string op5 = "";
	string indice ="";
	string warning="";
	string warningB ="";
	int id = 37;
	string ms1 ="";

	listaPreguntas ls = new listaPreguntas ();

	public Rect windowRect = new Rect(320, 70, 780, 650);
	public Rect windowWarn= new Rect (0, 0, 0, 0);
	public Rect windowWarnB= new Rect (0, 0, 0, 0);


	game g = new game();

	public void DoMyWindow(int windowID) {

		GUI.TextField (new Rect (20, 65, 225, 25), "Ingrese el enunciado de la pregunta:");
		pregunta = GUI.TextArea (new Rect (260, 50, 500, 50), pregunta);
		
		GUI.TextField (new Rect (20, 120, 250, 30), "Ingrese la primer opción de respuesta:");
		op1 = GUI.TextField ( new Rect (280, 120, 350, 30), op1);
		
		GUI.TextField (new Rect (20, 170, 250, 30), "Ingrese la segunda opción de respuesta:");
		op2 = GUI.TextField ( new Rect (280, 170, 350, 30), op2);
		
		GUI.TextField (new Rect (20, 210, 250, 30), "Ingrese la tercer opción de respuesta:");
		op3 = GUI.TextField ( new Rect (280, 210, 350, 30), op3);
		
		GUI.TextField (new Rect (20, 250, 250, 30), "Ingrese la cuarta opción de respuesta:");
		op4 = GUI.TextField ( new Rect (280, 250, 350, 30), op4);
		
		GUI.TextField (new Rect (20, 290, 250, 30), "Ingrese la quinta opción de respuesta:");
		op5 = GUI.TextField ( new Rect (280, 290, 350, 30), op5);
		
		GUI.TextField (new Rect (20, 330, 310, 30), "Ingrese el indice del numero de la opción correcta:");
		indice = GUI.TextField ( new Rect (335, 330, 50, 30), indice, 40);

		warning = GUI.TextField ( windowWarn, ms1);

		if(GUI.Button (windowWarnB, warningB)){
			
			ms1 = "";
			warningB ="";
			windowWarn= new Rect (0, 0, 0, 0);
			windowWarnB= new Rect (0, 0, 0, 0);

		}

		if (GUI.Button (new Rect (300, 380, 150, 50), "Ingresar Pregunta")) {
			
			if(comprobarVacios(pregunta)==false || comprobarVacios(indice)==false)
			{
				if(comprobarLetras(indice)==true)
				{
					int index =  int.Parse(indice);
					
					if(comprobarNum(index)==true)
					{
						if(comprobarOp(op1,op2,op3,op4,op5, index)==true)
						{
							if(id==37)
							{	
								ls.questions();
								
								pregunta p = new pregunta (pregunta, op1,op2,op3,op4,op5,index,id);
								id ++;
								ls.addPregunta(p);

								ms1 = "¡Pregunta agregada con éxito!.";
								warningB ="Aceptar";
								windowWarn=new Rect (0, 0, 0, 0);
								windowWarnB=new Rect (0, 0, 0, 0);
								windowWarn= new Rect (200, 520, 300, 30);
								windowWarnB= new Rect (320, 570, 100, 30);
							}
							else{
								
								pregunta p = new pregunta (pregunta, op1,op2,op3,op4,op5,index,id);
								id ++;
								ls.addPregunta(p);

								ms1 = "¡Pregunta agregada con éxito!.";
								warningB ="Aceptar";
								windowWarn=new Rect (0, 0, 0, 0);
								windowWarnB=new Rect (0, 0, 0, 0);
								windowWarn= new Rect (200, 520, 300, 30);
								windowWarnB= new Rect (320, 570, 100, 30);
							}
						}
						else{
							
							ms1 = "La pregunta debe contener por lo menos 2 opciones de respuesta y el índice debe pertenecer a una de estas.";
							warningB ="Aceptar";
							windowWarn=new Rect (0, 0, 0, 0);
							windowWarnB=new Rect (0, 0, 0, 0);
							windowWarn= new Rect (100, 520, 650, 30);
							windowWarnB= new Rect (320, 570, 100, 30);
						}
					}
					else{
						
						ms1 = "El índice debe ser un número entre el 1 y el 5.";
						warningB ="Aceptar";
						windowWarn=new Rect (0, 0, 0, 0);
						windowWarnB=new Rect (0, 0, 0, 0);
						windowWarn= new Rect (200, 520, 300, 30);
						windowWarnB= new Rect (320, 570, 100, 30);
						
					}
				}
				else{
					
					ms1 = "El índice no debe contener letras.";
					warningB ="Aceptar";
					windowWarn=new Rect (0, 0, 0, 0);
					windowWarnB=new Rect (0, 0, 0, 0);
					windowWarn= new Rect (200, 520, 300, 30);
					windowWarnB= new Rect (320, 570, 100, 30);
					
				}

			}
			else{

				ms1 = "Los campos Pregunta e Índice son obligatorios.";
				warningB ="Aceptar";
				windowWarn=new Rect (0, 0, 0, 0);
				windowWarnB=new Rect (0, 0, 0, 0);
				windowWarn= new Rect (200, 520, 300, 30);
				windowWarnB= new Rect (320, 570, 100, 30);
			}

			
		}
		
		if (GUI.Button (new Rect (270, 450, 200, 50), "Ingresar Otra Pregunta")) {
			//Application.LoadLevel ("Pregunta");
			pregunta = "";
			pregunta = GUI.TextArea (new Rect (260, 50, 500, 50), pregunta);
			
			op1 ="";
			op1 = GUI.TextField ( new Rect (280, 120, 350, 30), op1);
			
			op2 ="";
			op2 = GUI.TextField ( new Rect (280, 170, 350, 30), op2);
			
			op3 ="";
			op3 = GUI.TextField ( new Rect (280, 210, 350, 30), op3);
			
			op4 ="";
			op4 = GUI.TextField ( new Rect (280, 250, 350, 30), op4);
			
			op5 ="";
			op5 = GUI.TextField ( new Rect (280, 290, 350, 30), op5);
			
			indice ="";
			indice = GUI.TextField ( new Rect (335, 330, 50, 30), indice, 40);
		}
	}

	void OnGUI () {
	//windowRect = GUI.Window(0, windowRect, DoMyWindow, "Crear Pregunta");
		int aux = 0;

		windowRect = GUI.Window(0, windowRect, DoMyWindow, "Crear Pregunta");


	}

	public bool comprobarVacios(string cad)
	{
		if (cad == "") {
			return true;
		} else {
			return false;
		}
	}

	public bool comprobarLetras(string cad)
	{
		int cont = 0;
		foreach (char c in cad){
			if (char.IsLetter(c)) 
			{
				cont ++;
			}
		}

		if (cont == 0) {
			return true;
		} else {

			return false;
		}
	}

	public bool comprobarOp(string op1, string op2, string op3, string op4, string op5, int index)
	{
		if(comprobarOp2(op1,op2,op3,op4,op5)>=2){

			if(index ==1 && op1!="")
			{
				return true;
			}
			else{
				if(index ==2 && op2!="")
				{
					return true;
				}
				else{
					if(index ==3 && op3!="")
					{
						return true;
					}
					else{
						if(index ==4 && op4!="")
						{
							return true;
						}
						else{
							if(index ==5 && op5!="")
							{
								return true;
							}
							else{
								return false;
							}
						}
					}
				}
			}
		}
		else{
			return false;
		}


	}

	public int comprobarOp2(string op1, string op2, string op3, string op4, string op5)
	{
		int cont = 0;
		if(op1 !="")
		{
			cont ++;
		}
		if(op2 !="")
		{
			cont ++;
		}
		if(op3 !="")
		{
			cont ++;
		}
		if(op4 !="")
		{
			cont ++;
		}
		if(op5 !="")
		{
			cont ++;
		}
		Debug.Log ("Contador: "+cont);

		return cont;
	}


	public bool comprobarNum(int num)
	{
		if (num == 0) {
			return false;
		} else {
			if(num>5)
			{
				return false;
			}
			else{
				return true;
			}
		}
	}


}