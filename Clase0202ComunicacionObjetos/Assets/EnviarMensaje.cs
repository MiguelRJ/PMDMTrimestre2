using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Asignado a emisor
public class EnviarMensaje : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
		// Lanzar mensaje
		if (Input.GetKeyDown(KeyCode.Space)) {
			GameObject.FindGameObjectWithTag ("Receptor").SendMessage("MostrarDatos","soy un message");
		}
	}
}
