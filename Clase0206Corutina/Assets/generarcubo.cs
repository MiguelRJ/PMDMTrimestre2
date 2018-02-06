using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generarcubo : MonoBehaviour {

	public GameObject _cubo;
	public float _ratioTiempoLanzamiento = 1F;

	// Use this for initialization
	void Start () {
		StartCoroutine (LanzarCubo());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator LanzarCubo(){
		while (true) {
			Instantiate(_cubo, transform.position, Random.rotation);
			yield return new WaitForSeconds (_ratioTiempoLanzamiento);
		}
	}

}
