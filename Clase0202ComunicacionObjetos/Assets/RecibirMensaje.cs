using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Asignado a receptor
public class RecibirMensaje : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

	void MostrarDatos(string value){
		Debug.Log ("Soy el metodo MostrarDatos del receptor " + value);
	}

}
