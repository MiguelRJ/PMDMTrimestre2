using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour {

	const float GRADOS = 30F;
	Vector3 rotacion = new Vector3(GRADOS,GRADOS,GRADOS);
	
	void Update () {
		transform.Rotate (rotacion * Time.deltaTime);
	}
}
