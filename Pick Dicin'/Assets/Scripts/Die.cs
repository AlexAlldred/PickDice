using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour {
	RaycastHit determineNumber = new RaycastHit();
	public int currentNumber = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Physics.Raycast (transform.position, Vector3.up, out determineNumber);
		currentNumber = System.Convert.ToInt32(determineNumber.transform.name);
		Debug.DrawRay(transform.position, Vector3.up);
		Debug.Log (determineNumber.collider.gameObject.name);
	}
}
