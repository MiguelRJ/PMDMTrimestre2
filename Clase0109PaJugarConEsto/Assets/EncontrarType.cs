using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncontrarType : MonoBehaviour {

	Object[] _arrayLuces;

	// Use this for initialization
	void Start () {
		_arrayLuces = GameObject.FindObjectsOfType (typeof(Light));
		foreach(Object tmp in _arrayLuces) {
			Debug.Log (tmp.transform.name);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
