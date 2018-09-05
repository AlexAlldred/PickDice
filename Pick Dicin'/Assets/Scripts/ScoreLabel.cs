using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreLabel : MonoBehaviour {
	public float LabelScore = 5000;
	private TextMeshProUGUI label;
	public void Start()
	{
		transform.parent.GetComponentInChildren<TextMeshProUGUI>().SetText("Points");
		SetLabel ();
	}
	public void SetLabel()
	{
		if (transform.parent.GetComponent<Slider>().value != null) {
			LabelScore = transform.parent.GetComponent<Slider>().value;
			GetComponent<TextMeshProUGUI> ().SetText (LabelScore.ToString());
		}
	}
}
