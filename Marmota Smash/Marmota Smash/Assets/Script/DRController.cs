using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DRController : MonoBehaviour {

	public Material blue;
	public Material green;
	public Material yellow;
	public Material red;
	public Material currentMaterial;

	private List<Material> colorList;
	private float time = 0;

	// Use this for initialization
	void Start () {
		colorList = new List<Material> ();
		colorList.Add (blue);
		colorList.Add (green);
		colorList.Add (yellow);
		colorList.Add (red);

		ChangeMaterial ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		time += Time.deltaTime;

		if (time > 5) {
			ChangeMaterial ();
			time = 0;
		}
	}

	void ChangeMaterial() {
		int index = Random.Range (0, 4);
		GetComponent<Renderer> ().material = colorList[index];
		currentMaterial = colorList [index];
	}
}
