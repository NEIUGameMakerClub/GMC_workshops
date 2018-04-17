using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

	public Rigidbody sphere;
	public Renderer sphereRenderer;
	public Texture planetTexture;
	public Sprite mars;
	public Sprite venus;
	public Image planetImage;
	public Slider slider;

	public GUIStyle guiStyle;

	void Start () {
		
	}

	void Update(){
		sphere.transform.localScale = new Vector3 (slider.value, slider.value, slider.value);
		sphere.transform.Rotate (0, slider.value, 0);
	}

	public void ChangeTexture(){
		sphereRenderer.material.mainTexture = planetTexture;
	}
	
	public void PushSphere(){
		sphere.AddForce (sphere.transform.up * 1000);
	}

	public void ShowMars(){
		planetImage.sprite = mars;
	}

	public void ShowVenus(){
		planetImage.sprite = venus;
	}

	void OnGUI(){
		if (GUI.Button (new Rect (10, 300, 120, 80), "Change SPHERE")) {
			ChangeTexture ();
		}
		GUI.Label(new Rect (200, 300, 120, 80), "PUSH SPHERE", guiStyle);
			
	}
}
