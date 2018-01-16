using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//---
using UnityEngine.UI;

public class GestionGui : MonoBehaviour {

	public Texture icono;
	GameObject _luz;
	bool _toggle;

	// Use this for initialization
	void Start () {
		_luz = new GameObject ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		Rect pos = new Rect (300, 10, 50, 50);
		GUI.Button (pos, new GUIContent ("", icono));
		_luz = GameObject.Find ("Directional Light");
		_toggle = GUI.Toggle (new Rect (300, 100, 50, 50), _toggle, "Encender/Apagar Luz");
		_luz.GetComponent<Light> ().enabled = _toggle;
	}
}
