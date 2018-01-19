using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour {

	public float ancho = 50;
	public float alto = 50;
	public Texture[] texturas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	string[] botones = {"boton1","boton2","boton 3" };
	int botonActivo = 1;
	int grid = 0;
	float horizontal = 0;
	void OnGUI(){
		Rect pos = new Rect (200, 50, ancho, alto);
		botonActivo = GUI.Toolbar (pos, botonActivo, botones);
		grid = GUI.SelectionGrid (new Rect (200, 100, ancho, alto),grid,texturas,2);
		horizontal = GUI.HorizontalSlider (new Rect (300, 50, ancho, alto), horizontal, 0, 10);
	}
}
