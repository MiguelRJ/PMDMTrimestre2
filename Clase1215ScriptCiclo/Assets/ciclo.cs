using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ciclo : MonoBehaviour {

	void Awake (){
		Debug.Log ("Awake...");
	}
		
	void Start () {
		Debug.Log ("Start...");
	}

	void FixedUpdate (){
		Debug.Log ("FixedUpdate...");
	}

	void Update () {
		Debug.Log ("Update...");
	}

	void LateUpdate (){
		Debug.Log ("LateUpdate...");
	}

	void OnGUI (){
		Debug.Log ("OnGui...");
	}
}
