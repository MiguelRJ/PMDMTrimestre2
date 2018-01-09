using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	public GameObject _otro;
	public Transform _padre;
	Rigidbody _rb;
	Renderer _rd;

	void Awake () {
		_rb = GetComponent<Rigidbody>();
		_rd = GetComponent<Renderer>();
	}

	// Use this for initialization
	void Start () {
		_rb.mass = 10F;
		_rd.material.color = Color.red;

		_otro.transform.localScale = new Vector3(3, 2, 2);
		//_otro.GetComponent<Transform> ().localScale = new Vector3 (3, 2, 2);

		int i = 0;
		foreach (Transform tmp in _padre.transform)
			Debug.Log ("Hijo: " + i++.ToString () + ", " + tmp.name);
		_padre.FindChild ("Cylinder").GetComponent<Renderer> ().material.color = Color.cyan;


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
