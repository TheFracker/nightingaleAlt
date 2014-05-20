using UnityEngine;
using System.Collections;

public class RandomizeItems : MonoBehaviour {

	GameObject[] normal = new GameObject[13];
	GameObject[] alternative = new GameObject[13];
	int[] allNum = new int[13];
	public static int[] numToUse = new int[5];
	public static int o = 0;
	
	void Start () {

		// Two arrays that each contain all the items. One has all the items that have normal sounds
		// the other have all the items with alternative sounds
		for(int i = 0; i < 13; i++)
		{
			normal[i] = Resources.Load("Normal/Item_" + i) as GameObject;
			alternative[i] = Resources.Load("Alternative/Item_" + i) as GameObject;
			allNum[i] = i;
		}

		// 5 numbers that all have to be random
		for(int i = 0; i < 5; i++)
		{
			bool set = false;
			while(!set)
			{
				int rand = Random.Range(0,13);
				if(allNum[rand] != -1)
				{
					numToUse[i] = allNum[rand];
					allNum[rand] = -1;
					set = true;
				}
			}

			alternative [numToUse [i]].renderer.enabled = false;
			alternative [numToUse [i]].collider2D.enabled = false;
			alternative [numToUse [i]].tag = "item_" + i + "_a";
			normal [numToUse [i]].renderer.enabled = false;
			normal [numToUse [i]].collider2D.enabled = false;
			normal [numToUse [i]].tag = "item_" + i + "_n";
			Instantiate (normal [numToUse[i]], Vector3.right * -5, Quaternion.identity);
			Instantiate (alternative [numToUse[i]], Vector3.right * 5, Quaternion.identity);
		}

		// Show the first item on screen and also set its collider to true, so it can be clicked
		GameObject.FindGameObjectWithTag ("item_0_n").renderer.enabled = true;
		GameObject.FindGameObjectWithTag ("item_0_n").collider2D.enabled = true;
		GameObject.FindGameObjectWithTag ("item_0_a").renderer.enabled = true;
		GameObject.FindGameObjectWithTag ("item_0_a").collider2D.enabled = true;
	}
}
