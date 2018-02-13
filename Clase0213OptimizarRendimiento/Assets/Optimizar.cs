using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Asignado al jugador
public class Optimizar : MonoBehaviour {

	GameObject[] _enemigos; // lista de enemigos

	// Use this for initialization
	void Start () {
		_enemigos = GameObject.FindGameObjectsWithTag ("Enemigo");
	}
	
	// Update is called once per frame
	void Update () {
		ComprobarProxEnemigo ();
	}

	// Ver.1 Comprobar la proximidad de cualquier enemigo
	void ComprobarProxEnemigo(){
		float maxDistanciaPermitida = 1.5F;

		foreach (GameObject enemigoTmp in _enemigos) {
			if (Vector3.Distance (transform.position, enemigoTmp.transform.position) < maxDistanciaPermitida) {
				enemigoTmp.GetComponent<Enemigo> ().Detectado();
			} else {
				enemigoTmp.GetComponent<Enemigo> ().NoDetectado ();
			}
		}

	}

}
