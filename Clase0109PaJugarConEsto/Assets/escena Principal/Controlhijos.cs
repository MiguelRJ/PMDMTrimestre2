using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlhijos : MonoBehaviour {

	public Transform _padre;
	public Rigidbody _rd;
	int i = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Agregar hijos
		if (Input.GetMouseButton (0)) {
			GameObject hijo = new GameObject ("Hijo_"+i++.ToString());
			hijo.transform.parent = _padre;
		}

		// Buscar por nombre
		if (Input.GetMouseButtonDown (1)) {
			if (_padre.childCount > 0) {
				string nombreHijo = _padre.transform.GetChild (0).name;
				GameObject hijo = _padre.FindChild (nombreHijo).gameObject;
				Destroy (hijo);
			}
		}

		//GameObject.FindObjectsOfType ();
		// crea objeto vacio 4 hijos localizarlos por tag
	}

	void crearObjeto() {
		GameObject cubo = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cubo.transform.position = new Vector3 (1, 1, 1);
	}

}
