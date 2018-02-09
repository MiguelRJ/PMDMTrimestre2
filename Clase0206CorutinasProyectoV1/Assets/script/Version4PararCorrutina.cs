using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Para parar Corrutinas
public class Version4PararCorrutina : MonoBehaviour {

	int nSaludo = 0;
	bool ejecutar = true;

	void Start () {
		//StartCoroutine ("saludaCadaSegundo"); // se inicia on enabled
	}

	void Update (){
		/*if (Input.GetKeyDown (KeyCode.P)) {
			StopCoroutine ("saludaCadaSegundo");
			Debug.Log ("Parada la corrutina (saludaCadaSegundo)");
		}

		if (Input.GetKeyDown (KeyCode.S)) {
			ejecutar = true;
			StartCoroutine (saludaCadaSegundo("hola bros",2F));
			Debug.Log ("Lanzada la corrutina (saludaCadaSegundo)");
		}*/

		if (Input.GetKeyDown (KeyCode.F)) {
			ejecutar = false;
		}
		if (Input.GetKeyDown (KeyCode.T)) {
			ejecutar = true;
		}
	}
	
	IEnumerator saludaCadaSegundo(string msg, float time){
		
		while (ejecutar) {
			if (!ejecutar) {
				yield break;
			}
			Debug.Log ("Hola ... "+msg+" "+ nSaludo++);
			yield return new WaitForSecondsRealtime (time);
		}
		Debug.Log ("salio del while");

	}

	public void OnEnable() {
		StartCoroutine (saludaCadaSegundo("hola bros",1F));
		StartCoroutine (saludaCadaSegundo("hola eliseo",0.25F));
	}

	public void OnDisable() { // cuando deshabilitas el script en el gameobject
		StopAllCoroutines ();
	}

}
