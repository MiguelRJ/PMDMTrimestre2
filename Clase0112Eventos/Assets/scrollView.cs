using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollView : MonoBehaviour {

	Vector2 posMostrarScrollView = new Vector2(10,10);
	string contenido = "Este es el texto del contenido del Elemento";
	public Rect posMostrarArea = new Rect (10,10,200,200);
	public Rect posMostrarArea2 = new Rect (215,10,200,200);
	public Rect posMostrarArea3 = new Rect (420,10,200,200);
	public Rect posMostrarContenido = new Rect (0,0,400,400);
	public Texture textura;
	int id = 0;
	bool _mostrar1 = true;

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab)) {
			_mostrar1 = !_mostrar1;
		}
	}

	// ScrollView
	/**
	 * Window unico control que necesita una funcion asociada a el 
	 * id, rect, texto ventana	
	 */
	void OnGUI(){
		/*posMostrarScrollView = GUI.BeginScrollView (posMostrarArea, posMostrarScrollView, posMostrarContenido);
		GUI.TextArea (new Rect (0, 0, 400, 400), contenido);
		GUI.Button (new Rect (10,20,100,30),"pulsame");
		GUI.EndScrollView ();*/

		// Si el contenido del Rect es < el texto a mostrar este se recorta por ambos lados al mostrarse centrado
		if (_mostrar1) {
			posMostrarArea = GUI.Window (id, posMostrarArea, EjecutarFuncion, contenido);
		}
		posMostrarArea2 = GUI.Window(id+1, posMostrarArea2, EjecutarFuncion, contenido);
		posMostrarArea3 = GUI.Window(id+2, posMostrarArea3, EjecutarFuncion, textura);

	}

	void EjecutarFuncion(int idWindow){
		if (GUI.Button(new Rect(10,20,100,20), "Pulsame")) {
			Debug.Log ("Has hecho click en el boton de la ventana cuyo id vale: " + idWindow);
		}
		// Para poder mover la ventana
		GUI.DragWindow(new Rect(0,0,1000,1000));
	}

}
