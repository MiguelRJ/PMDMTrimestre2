using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Version1IF : MonoBehaviour {

	const int NCUBOS = 3;
	GameObject[] cubos = new GameObject[NCUBOS];
	float destinoZCubo = -4F;
	Vector3 velocidad = new Vector3(0,0,-5.5F);

	// Use this for initialization
	void Start () {
		localizarCubos ();
	}
	
	// Update is called once per frame
	void Update () {
		moverCubos ();
	}

	void localizarCubos() {
		cubos [0] = GameObject.Find ("Cube1");
		cubos [1] = GameObject.Find ("Cube2");
		cubos [2] = GameObject.Find ("Cube3");
	}

	void moverCubos() {
		// Desplaza cada cubo hasya el final del recorrrido
		if (cubos [0].GetComponent<Transform> ().position.z > destinoZCubo) {
			cubos [0].GetComponent<Transform> ().Translate (velocidad.x, velocidad.y, velocidad.z * Time.deltaTime);
		} else if (cubos [1].GetComponent<Transform> ().position.z > destinoZCubo) {
			cubos [1].GetComponent<Transform> ().Translate (velocidad.x, velocidad.y, velocidad.z * Time.deltaTime);
		} else if (cubos [2].GetComponent<Transform> ().position.z > destinoZCubo) {
			cubos [2].GetComponent<Transform> ().Translate (velocidad.x, velocidad.y, velocidad.z * Time.deltaTime);
		}
	}

}
