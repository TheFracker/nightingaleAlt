﻿using UnityEngine;
using System.Collections;

public class Right : MonoBehaviour {

	void Update () {
		if(RandomizeItems.o < 4)
		{
			gameObject.renderer.enabled = true;
			gameObject.collider2D.enabled = true;
		}	
		else
		{
			gameObject.renderer.enabled = false;
			gameObject.collider2D.enabled = false;
		}
	}

	void OnMouseUpAsButton()
	{
		GameObject.FindGameObjectWithTag ("item_" + RandomizeItems.o + "_n").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("item_" + RandomizeItems.o + "_a").renderer.enabled = false;
		RandomizeItems.o++;
		GameObject.FindGameObjectWithTag ("item_" + RandomizeItems.o + "_n").renderer.enabled = true;
		GameObject.FindGameObjectWithTag ("item_" + RandomizeItems.o + "_n").renderer.enabled = true;
	}
}
