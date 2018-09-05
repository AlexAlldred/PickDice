using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {
	private int numberOfDice = 6;
	private int savedDice = 0;
	private int score = 0;
	private int MaxScore = 5000;
	private int turn = 1;
	private bool rollEnable = true;
	private bool pickEnable = true;

	public List<Die> Dice = new List<Die> ();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = turn; i < 100; i++) {
			if (rollEnable) {
				//Roll
				Roll();
			} else if (pickEnable) {

			}
		}
	}

	public void Roll()
	{

	}
}
