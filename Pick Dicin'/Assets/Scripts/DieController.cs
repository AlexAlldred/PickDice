using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieController : MonoBehaviour
{
    public Light _light;
    private int Value = 0;
    private bool Rolled = false;
    public bool _active = true; //if _active the die is still in play else it's being counted

    //Sides
    private float[] Sides = new float[6];
    //index 4 = value 5
    //index 3 = value 6
    //index 1 = value 2
    //index 0 = value 1
    //index 5 = value 4
    //index 2 = value 3

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void FixedUpdate()
    {
        if (!Rolled)  //if Player has not rolled or previous values have been counted
        {
            if (Value == 0) //If value has not been set yet
            {
                if (GetComponent<Rigidbody>().IsSleeping())  //if Die has stopped moving 
                {
                    Roll();
                }
            }
            Debug.Log(Value.ToString());

        }
    }

    private int FindValueFromIndex(int index)
    {
        if(index == 1)
        {
            return 2;
        }
        if (index == 2)
        {
            return 3;
        }
        if (index == 3)
        {
            return 6;
        }
        if (index == 4)
        {
            return 5;
        }
        if (index == 5)
        {
            return 4;
        }
        if (index == 0)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }

    public int Roll()
    {
            Sides[0] = Vector3.Dot(transform.up, Vector3.up);
            Sides[1] = Vector3.Dot(transform.right, Vector3.up);
            Sides[2] = Vector3.Dot(transform.forward, Vector3.up);
            Sides[3] = Vector3.Dot(-transform.up, Vector3.up);
            Sides[4] = Vector3.Dot(-transform.right, Vector3.up);
            Sides[5] = Vector3.Dot(-transform.forward, Vector3.up);
            int highestIndex = 0;

            for (int i = 1; i < 6; i++)
            {
                // Debug.Log("i: " + i.ToString() + " Value: " + Sides[i].ToString());
                if (Sides[highestIndex] < Sides[i])
                {
                    highestIndex = i;
                }
            }

            Value = FindValueFromIndex(highestIndex);
            if (Value == 5 || Value == 1)
            {
                _light.color = Color.green;
            }
            else
            {
                _light.color = Color.white;
            }
            return Value;
        
    }
}
