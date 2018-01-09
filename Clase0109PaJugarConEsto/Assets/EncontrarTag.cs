using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncontrarTag : MonoBehaviour {

	GameObject[] _arrayMalos;

	// Use this for initialization
	void Start () {
		_arrayMalos = GameObject.FindGameObjectsWithTag ("Malo");
		foreach(GameObject tmp in _arrayMalos) {
			if (tmp.transform.parent.name == "Malos") {
				tmp.GetComponent<Renderer> ().material.color = Color.red;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
