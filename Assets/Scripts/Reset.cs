using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {
	public GameObject cube1;
	public GameObject cube2;
	public GameObject cube3;
	public GameObject cube4;
	public GameObject cube5;
	public GameObject cube6;
	public GameObject cube7;
	public GameObject cube8;
	public GameObject cube9;

	public Material material;
//	private Renderer rend;

	// Use this for initialization
	void Start () {
//		rend = GetComponent<Renderer> ();
//		rend.enabled = true;
//		rend.sharedMaterial = materials [0];
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		cube1.GetComponent<Renderer> ().sharedMaterial = material;
		cube2.GetComponent<Renderer> ().sharedMaterial = material;
		cube3.GetComponent<Renderer> ().sharedMaterial = material;
		cube4.GetComponent<Renderer> ().sharedMaterial = material;
		cube5.GetComponent<Renderer> ().sharedMaterial = material;
		cube6.GetComponent<Renderer> ().sharedMaterial = material;
		cube7.GetComponent<Renderer> ().sharedMaterial = material;
		cube8.GetComponent<Renderer> ().sharedMaterial = material;
		cube9.GetComponent<Renderer> ().sharedMaterial = material;

	}
}
