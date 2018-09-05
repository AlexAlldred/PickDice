using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameWindow : MonoBehaviour {
	private int[] Names = new int[6];
	public GameObject[] NameObj = new GameObject[6];
	// Use this for initialization
	void Start () {
		SetNumberPlayers();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetNumberPlayers()
	{
		int NumOfPlayers = (int)transform.parent.GetComponentInChildren<NumberLabel> ().LabelNum;

		for (int i = 0; i < 6; i++) {
			if (i <= NumOfPlayers-1) {
				NameObj [i].SetActive (true);
			} else {
				NameObj [i].SetActive (false);
			}
		}
	}
}
