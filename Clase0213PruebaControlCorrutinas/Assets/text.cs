using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//---
using UnityEngine.UI;

public class text : MonoBehaviour {

	string url = "http://ascii-art.de/ascii/ab/badger.txt";
	public Text txt;

	// Use this for initialization
	void Start () {
		StartCoroutine ("cargarTxt");
	}

	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator cargarTxt(){
		// Text _textUi = GetComponent<Text> ();
		txt.text = "Cargando fichero";
		WWW _www = new WWW (url);
		yield return _www;
		string contenidoFicheroTexto = _www.text;
		txt.text = contenidoFicheroTexto;
	}
}
