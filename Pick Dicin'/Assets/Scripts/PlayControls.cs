using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayControls : MonoBehaviour {
    public GameObject gatherPoint;
    public bool isTurn = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetMouseButton(0) && isTurn)
        {
           // gatherPoint.transform.position.Set(Input.mousePosition.x, gatherPoint.transform.position.y, gatherPoint.transform.position.z);
            Gather();
        }
	}

    public void Gather()
    {
        float speed = 0.3f;
        foreach (Rigidbody r in GetComponentsInChildren<Rigidbody>())
        {
            speed = Vector3.Distance(r.transform.position, gatherPoint.transform.position)/15;
            r.transform.position = Vector3.MoveTowards(r.transform.position, gatherPoint.transform.position, speed);
          
        }
    }
}
