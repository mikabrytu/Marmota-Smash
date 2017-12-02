using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleController : MonoBehaviour {

	public Material blue;
	public Material green;
	public Material yellow;
	public Material red;

	private ScoreController scoreController;
	private DRController drController;
	private List<Material> colorList;
	private Material currentMaterial;
	private float time = 0;
	private bool clicked = false;
	private int interval;

	// Use this for initialization
	void Start () {
		colorList = new List<Material>();
		colorList.Add (blue);
		colorList.Add (green);
		colorList.Add (yellow);
		colorList.Add (red);

		GameObject scoreContainer = GameObject.Find ("Score");
		scoreController = scoreContainer.GetComponent<ScoreController> ();

		GameObject drContainer = GameObject.Find ("DR Container");
		drController = drContainer.GetComponent<DRController> ();

		SetInterval ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		time += Time.deltaTime;

		if (time > interval) {
			ChangeMaterial ();
			SetInterval ();
			time = 0;
			clicked = false;
		}
	}

	void OnMouseDown() {
		if (clicked) {
			scoreController.RemoveScore (5);
		} else {
			clicked = true;

			if (currentMaterial == drController.currentMaterial) {
				scoreController.AddScore (5);
			} else {
				scoreController.RemoveScore (5);
			}
		}
	}

	void ChangeMaterial() {
		int index = Random.Range (0, 4);
		GetComponent<Renderer> ().material = colorList[index];
		currentMaterial = colorList[index];
	}

	void SetInterval () {
		interval = Random.Range (1, 5);
	}
}
