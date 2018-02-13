using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//---
using UnityEngine.UI;

public class recursoWeb : MonoBehaviour {

	string url = "http://www.iesportada.org/images/Actos/eu_code_week_1cfgm.red.jpg";
	public RawImage rawImage;
	public Image image;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			StartCoroutine ("cargar");
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			StartCoroutine ("cargarUIImg");
		}
	}

	IEnumerator cargar(){
		WWW _www = new WWW (url);
		yield return _www;
		Texture2D textura = _www.texture;
		rawImage.GetComponent<RawImage> ().texture = textura;
	}

	IEnumerator cargarUIImg(){
		WWW _www = new WWW (url);
		yield return _www;
		Sprite _sprite = TexturaASprite(_www.texture);
		image.GetComponent<Image> ().sprite = _sprite;
	}

	// Metodo privado que comvierte una textura a sprite
	private Sprite TexturaASprite(Texture2D textura){
		Rect rect = new Rect(0,0, textura.width,textura.height);
		Vector2 pivot = new Vector2 (0.5F, 0.5F);
		Sprite sprite = Sprite.Create (textura, rect, pivot);
		return sprite;
	}
}
