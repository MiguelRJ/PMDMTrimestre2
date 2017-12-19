using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//---
using UnityEngine.UI;

public class ControladorDelJugador : MonoBehaviour {

	Rigidbody rb;
	public float velocidad = 2;
	// Para la puntuacion
	int contador = 0;
	public Text puntuacion;
	public bool juegoAcabado;

	void Awake () {
		rb = transform.GetComponent<Rigidbody> ();
		juegoAcabado = false;
	}

	void FixedUpdate () {
		float movimientoHorizontal = Input.GetAxis ("Horizontal");
		float movimientoVertical = Input.GetAxis ("Vertical");
		Vector3 movimiento = new Vector3 (movimientoHorizontal, 0, movimientoVertical);
		if(!juegoAcabado) {
			rb.AddForce (movimiento * velocidad);
		}
	}

	void OnTriggerEnter(Collider other){
		Destroy(other.gameObject);
		contador++;
		puntuacion.text = "Puntos: " + contador;
	}
}
