using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Version2Corutinas : MonoBehaviour {

	const int NCUBOS = 3;
	GameObject[] cubos = new GameObject[NCUBOS];
	float destinoZCubo = -4F;
	Vector3 velocidad = new Vector3(0,0,-5.5F);
	Vector3 velrotacion = new Vector3(0,0,50);

	// Use this for initialization
	void Start () {
		localizarCubos ();
		StartCoroutine (moverCubos ()); // tambien se puede poner el nombre del metodo en string ("moverCubos")
	}

	void localizarCubos() {
		cubos [0] = GameObject.Find ("Cube1");
		cubos [1] = GameObject.Find ("Cube2");
		cubos [2] = GameObject.Find ("Cube3");
	}

	IEnumerator moverCubos(){
		// Mueve cubo a cubo hasta el destino
		foreach (GameObject cuboTmp in cubos) {
			
			while (cuboTmp.GetComponent<Transform> ().position.z > destinoZCubo) {
				cuboTmp.transform.Translate (velocidad.x, velocidad.y, velocidad.z * Time.deltaTime);
				yield return null;
			}

			yield return StartCoroutine ("rotarCubos",cuboTmp);

		}
	}

	IEnumerator rotarCubos(GameObject cuboTmp){

		// Rota cada cubo al llegar al destino
		while (cuboTmp.GetComponent<Transform> ().rotation.eulerAngles.z < 90) {
			Vector3 anguloActual = cuboTmp.transform.rotation.eulerAngles;
			cuboTmp.GetComponent<Transform>().rotation = Quaternion.Euler (anguloActual + velrotacion * Time.deltaTime);
			yield return null;
		}
			
	}

}
