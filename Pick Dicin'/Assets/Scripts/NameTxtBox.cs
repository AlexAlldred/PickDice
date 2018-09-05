using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameTxtBox : MonoBehaviour {

	void Start()
	{
		GetComponent<TMP_InputField> ().characterLimit = 3;
	}
	public void TrimName(){
		//string name = GetComponent<TMP_InputField> ().text;

	}
}
