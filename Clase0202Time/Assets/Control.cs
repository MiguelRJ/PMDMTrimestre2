using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	Vector3 posIniObj;
	Vector3 posActObj;
	float posXAct;
	float posYAct;
	float posZAct;
	float velocidad = 0.05F;
	float minX = -4.5F;
	float maxX = 4.5F;
	float minZ = -4.5F;
	float maxZ = 4.5F;
	float velRotacion = 2.5F;

	// Capturas
	string carpetaCapturas = "Capturas";
	int frameRate = 25;

	// Use this for initialization
	void Start () {
		Time.captureFramerate = frameRate;
		System.IO.Directory.CreateDirectory (carpetaCapturas);
	}
	
	void Update(){
		if (Input.GetKeyDown (KeyCode.X)) {
			Time.timeScale = 0;
		}
		if (Input.GetKeyDown (KeyCode.Z)) {
			Time.timeScale = 1;
		}

		// Guardar capturas
		string nombre = string.Format("{0}/{1:D04}_captura.png", carpetaCapturas, Time.frameCount);
		Application.CaptureScreenshot (nombre);
	}
		
	void FixedUpdate () {
		transform.Rotate(new Vector3(velRotacion, velRotacion,velRotacion));
		MoverElCubo ();
	}

	void OnGUI(){
		// Mostrar el valor de timeScale
		GUI.Label(new Rect(10,10,200,30), "TimeScale: "+ Time.timeScale);
	}

	void MoverElCubo(){
		// Mueve el cubo en X Y Z en un area determinada

		// Leo la coordenada X
		posXAct = transform.position.x + (Input.GetAxis("Horizontal") * velocidad);
		posActObj = new Vector3 (Mathf.Clamp (posXAct, minX, maxX),
			transform.position.y,
			transform.position.z);
		transform.position = posActObj;

		// Leo la coordenada Z
		posZAct = transform.position.z + (Input.GetAxis("Vertical") * velocidad);
		posActObj = new Vector3 (transform.position.x, transform.position.y, Mathf.Clamp (posZAct, minZ, maxZ));
		transform.position = posActObj;
	}

}
