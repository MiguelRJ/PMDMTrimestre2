using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emisor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.Space)) {
			// Creo un cubo para pasarlo como parametro
			GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cubo.name = "Micubo";
			cubo.SetActive (false);
			// Etc..

			GameObject obj = GameObject.Find ("Receptor");
			obj.SendMessage ("ReceptorMensaje", cubo);
		}

		if (Input.GetKey(KeyCode.B)) {
			GameObject obj = GameObject.Find ("padre");
			obj.BroadcastMessage("ReceptorBroadcast");

		}

	}

}
