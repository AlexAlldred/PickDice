using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClampSlider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnChange(){
		int val = (int)GetComponent<Slider> ().value;

		if (val % 100 >= 50) {
			val += val % 100;
		} else if(val % 100 < 50 && val % 100 != 0) {
			val -= val % 100;
		}

		GetComponent<Slider> ().value = val;
	}
}
