using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour {

	int botonClicked = 0;
	string[] listaBotones = {"Uno","Dos","Tres" };
	string contenido = "Modificame ...";
	//Crear variables para estilos
	public GUIStyle estiloBoton;
	public GUISkin controladorSkin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI() {
		GUI.skin = controladorSkin;
		contenido = GUI.TextField (new Rect (10, 100, 300, 30), contenido,30);
		GUI.Label (new Rect (10, 150, 100, 50), "Soy un label camuflado a caja","box");
		GUI.Button (new Rect (10, 210, 100, 50), "Soy el boton 1");

		GUI.skin = null; // aqui pierde el guiskin y toma el predefinido
		GUI.Button (new Rect (200, 210, 100, 50), "Soy el boton 2");
	}
		
	/* 


	if (GUI.changed) {
			Debug.Log ("El contenido ha cambiado");
	}

	botonClicked = GUI.Toolbar (new Rect (10,10,120,75),botonClicked,listaBotones);
		if (GUI.changed) {
			Debug.Log ("Has hecho click en el Toolbar");
			switch (botonClicked) {
				case 0: 
					Debug.Log ("Primer boton");
					break;
				case 1: 
					Debug.Log ("Segundo boton");
					break;
				case 2:
					Debug.Log ("Tercer boton");
					break;
				default:
					break;
			}
	}*/

}

