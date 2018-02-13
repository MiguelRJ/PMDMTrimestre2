using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectosCorrutina : MonoBehaviour {

	public Light _luz;

	public void IniParpadeo(){
		StartCoroutine ("parpadeo");
	}
	public void FinParpadeo(){
		StopCoroutine ("parpadeo");
	}
	public void IniColor(){
		StartCoroutine ("cambiarColor");
	}
	public void FinColor(){
		StartCoroutine ("cambiarColor");
	}

	IEnumerator parpadeo(){
		int _nVeces = 20;
		while (true) {
			for (int i = 0; i < _nVeces; i++) {
				_luz.enabled = !_luz.enabled;
				yield return new WaitForSeconds (Random.Range (0.1F, 0.5F));
			}
			_luz.enabled = Random.Range (0, 2) == 0;
			yield return new WaitForSeconds (3);
		}
	}

	IEnumerator cambiarColor(){
		while (true) {
			_luz.color = Color.Lerp (Color.blue, Color.red, Mathf.PingPong (Time.time / 2, 1));
			yield return null;
		}
	}

}
