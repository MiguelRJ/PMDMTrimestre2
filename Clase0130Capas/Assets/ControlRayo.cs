using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRayo : MonoBehaviour { // asignado a la camara

	//int _maskCapa = 1 << 8; // tambien puedo asignarle 256 en decimal 1 0000 0000. La capa 8 del layer mask.

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		// El rayo intersecta a cualquier objeto delante de el

		int _maskCapa = 1 << 8;
		_maskCapa = ~_maskCapa;

		RaycastHit _hit;

		// Punto de partida
		Vector3 _origen = transform.position;

		// Direccion. En este caso en z
		Vector3 _direccion = Vector3.forward;

		// Alcance o distancia
		float _distancia = Mathf.Infinity;

		// Devuelve verdad si se produce colision del rayo con algun objeto
		if (Physics.Raycast (_origen, transform.TransformDirection(_direccion),out _hit, _distancia, _maskCapa)) {
			Debug.Log ("colision");
			Debug.DrawRay (_origen, transform.TransformDirection(_direccion) * _hit.distance, Color.green );
		} else {
			Debug.Log ("...");
			Debug.DrawRay (_origen, transform.TransformDirection(_direccion), Color.yellow, 1000);
		}
			
	}

	void OnDrawGizmos(){

	}
}
