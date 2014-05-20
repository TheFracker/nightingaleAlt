using UnityEngine;
using System.Collections;

public class Text : MonoBehaviour {
	
	void Start () {
		gameObject.guiText.fontSize = 50;
	}

	void Update () {
		gameObject.guiText.text = "Item " + (RandomizeItems.numToUse[RandomizeItems.o] + 1);
	}
}
