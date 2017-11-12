using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoller : MonoBehaviour {

	void Start () {
        DiceValues = new int[4];
	}
	
	void Update () {
		
	}
    public int[] DiceValues;
    public int DiceTotal;

    public void RollTheDice()
    {
        //in Ur, you roll four dice ( classically Tetahedron), which
        //have half their faces have a value of "1" and half have a value of zero.

        //You COULD roll actual physics enabled dice.

        //We are going to use random number generation instead.

        DiceTotal = 0;
        for (int i = 0; i < DiceValues.Length; i++)
        {
            DiceValues[i] = Random.Range(0, 2);
            DiceTotal += DiceValues[i];
        }

        Debug.Log("Rolled " + DiceValues + " (" + DiceTotal + ")");
    }
}
