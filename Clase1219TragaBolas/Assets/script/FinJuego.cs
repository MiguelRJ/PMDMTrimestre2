using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//---
using UnityEngine.UI;

public class FinJuego : MonoBehaviour {

	public GameObject items;
	public Text finJuego;
	public GameObject jugador;

	void Start () {
		finJuego.enabled = false;
	}
	
	void Update () {
		if(items.transform.childCount <= 0){
			finJuego.enabled = true;
			transform.GetComponent<Tiempo> ().juegoAcabado = true;
			jugador.GetComponent<ControladorDelJugador> ().juegoAcabado = true;
			jugador.GetComponent<Rigidbody> ().velocity = Vector3.zero;
		}
	}
}
