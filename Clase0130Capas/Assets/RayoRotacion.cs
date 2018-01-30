using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoRotacion : MonoBehaviour {

	RaycastHit _hit;
	float _distancia = 6;
	public float _velocidadRotacion = 10;

	// Use this for initialization
	void Start () {
		
	}

	void Update() {
		transform.Rotate (Vector3.up * _velocidadRotacion * Time.deltaTime);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Physics.Raycast (transform.position, transform.right, out _hit, _distancia)) {
			Debug.Log ("Detectado: "+ _hit.collider.name);
			Debug.DrawRay (transform.position, transform.right * _distancia, Color.green);
		} else {
			Debug.DrawRay (transform.position, transform.right * _distancia, Color.red);
		}
	}

}
