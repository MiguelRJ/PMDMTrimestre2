using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controljuego : MonoBehaviour {

	float velocidadRotacion = 4.5F;
	Vector3 anguloRotacion = new Vector3(0.33F, 0.33F, 0.33F);
	float fuerzaImpulso;

	// Use this for initialization
	void Start () {
		fuerzaImpulso = 10F;
		GetComponent<Rigidbody> ().AddForce (Vector3.up * fuerzaImpulso, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (anguloRotacion * velocidadRotacion);
	}
}
