using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlOnGui : MonoBehaviour {

	bool mostrar;
	// Use this for initialization
	void Start () {
		mostrar = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Interfaz grafico
	string textoInicial = "Escribe algo";
	public void OnGUI() {
		MostrarBoton ();
		MostrarRepiteBoton ();
		if (mostrar) {
			MostrarLabel (textoInicial);
		}
		textoInicial = GUI.TextField (new Rect (150, 10, 100, 30), textoInicial);
		textoInicial = GUI.TextArea (new Rect (10, 200, 300, 50), textoInicial);
	}

	void MostrarLabel(string texto) {
		//string textoMostrado = "Soy el texto de ejemplo";
		int _anchoCaracter = 6;
		float x = (float)Screen.width / 2 - (texto.Length * _anchoCaracter) / 2;
		float y = 50;
		float ancho = 300;
		float alto = 20;
		Rect _rect = new Rect (x, y, ancho, alto);
		GUI.color = Color.red;
		GUI.Label (_rect, texto);
	}

	void MostrarBoton(){
		GUI.Button (new Rect (10, 10, 100, 30), new GUIContent ("Pulsame", "Tooltip de boton"));
		GUI.Button (new Rect (10, 60, 100, 30), new GUIContent ("Pulsame2", "Tooltip de boton2"));
		GUI.Label (new Rect(10,40,300,40), GUI.tooltip);
	}

	void MostrarRepiteBoton() {
		if ( GUI.RepeatButton (new Rect (10, 100, 100, 30), "Repite") ) {
			mostrar = !mostrar;
		}
	}

}
