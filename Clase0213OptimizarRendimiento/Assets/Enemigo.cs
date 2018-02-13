using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

	Texture _texturaObj;

	// Use this for initialization
	void Start () {
		_texturaObj = GetComponent<Texture> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Detectado(){
		// Hago muchas cosas
		GetComponent<Renderer>().material.color = Color.black;
	}

	public void NoDetectado(){
		// Hago muchas cosas
		GetComponent<Renderer>().material.color = Color.white;
	}

}
