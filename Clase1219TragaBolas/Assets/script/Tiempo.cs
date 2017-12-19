using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//---
using UnityEngine.UI;

public class Tiempo : MonoBehaviour {

	public int tiempo = 4000;
	public Text tiempoText;
	public bool juegoAcabado;

	void Start () {
		juegoAcabado = false;
	}
	
	void FixedUpdate () {
		if (!juegoAcabado) {
			tiempo--;
		}
	}

	void LateUpdate(){
		tiempoText.text = tiempo.ToString ("0000");
	}

}
