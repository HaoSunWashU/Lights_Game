using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour {
	public GameObject[] cubes;
	public Text winText;
	public Material[] materials;
	private bool win = false;


	// Use this for initialization
	void Start () {
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		int i;
		for (i = 0; i < cubes.Length; i++) {
			if (cubes [i].GetComponent<Renderer> ().sharedMaterial == materials [0]) {
				win = false;
				winText.text = "";
				break;

			}
		}
		if(i == cubes.Length)
		{
			win = true;
			winText.text = "You Win, press reset to restart the game";
		}
	}


}
