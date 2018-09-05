using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberLabel : MonoBehaviour {
	public float LabelNum = 1;
	private TextMeshProUGUI label;
	public void Start()
	{
		transform.parent.GetComponentInChildren<TextMeshProUGUI>().SetText("Player");
		SetLabel ();
	}
	public void SetLabel()
	{
		if (transform.parent.GetComponent<Slider>().value != null) {
			LabelNum = transform.parent.GetComponent<Slider>().value;
			GetComponent<TextMeshProUGUI> ().SetText (LabelNum.ToString());
			if (LabelNum == 1) {
				transform.parent.GetComponentInChildren<TextMeshProUGUI> ().SetText ("Player");
			} else {
				transform.parent.GetComponentInChildren<TextMeshProUGUI> ().SetText ("Players");
			}
		}
	}

}
