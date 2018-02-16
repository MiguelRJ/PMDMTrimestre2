using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Asignado al jugador
public class Optimizar : MonoBehaviour {

	GameObject[] _enemigos; // lista de enemigos

	// Use this for initialization
	void Start () {
		_enemigos = GameObject.FindGameObjectsWithTag ("Enemigo");
		StartCoroutine (ComprobarProxEnemigo ());
	}


	// Ver.1 Comprobar la proximidad de cualquier enemigo
	IEnumerator ComprobarProxEnemigo(){
		float maxDistanciaPermitida = 1.5F;

		while (true) {
			
			foreach (GameObject enemigoTmp in _enemigos) {
				
				if (Vector3.Distance (transform.position, enemigoTmp.transform.position) < maxDistanciaPermitida) {
					enemigoTmp.GetComponent<Enemigo> ().Detectado ();
				} else {
					enemigoTmp.GetComponent<Enemigo> ().NoDetectado ();
				}

			}

			yield return new WaitForSeconds (0.2F);
		}

	}

}
