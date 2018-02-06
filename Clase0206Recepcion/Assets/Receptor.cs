using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receptor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ReceptorMensaje(GameObject obj){
		// Activar el obj recibido
		obj.SetActive(true);
		obj.transform.localScale *= 2;
		obj.AddComponent<Rigidbody>();
	}

}
