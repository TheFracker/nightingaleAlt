using UnityEngine;
using System.Collections;

public class Text : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.guiText.fontSize = 50;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.guiText.text = "Item " + (RandomizeItems.numToUse[RandomizeItems.o] + 1);
	}
}
