/*
 * This is just a game that sets a range and tries to guess what number a user is thinking of.
 * The method is to pplace the guess at the middle of the range and continue to change the range
 * based on the guess value and user feedback.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {
    int max;
    int min;
    int guess;

	// Use this for initialization
	void Start () {
        StartGame();
	}
	
    void StartGame () {
        max = 1000;              //set the initial value
        min = 1;                 //set the initial value
        guess = (min + max) / 2; //Do not use a hard-coded value when all you're doing is finding the half way point.
        max += 1;                //prevent from rounding down and allow access to the number 1000

        print("==================================================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me.");

        print("The highest number you can pick is " + (max-1) + ".");
        print("The lowest number you can pick is " + min + ".");

        print("Is the number higher or lower than " + guess + "?");
        print("Press the up arrow for higher than, down arrow for less than and Return for equal to.");
    }

    // Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            min = guess; //adjust the lower end of the range
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess; //adjust the upper end of the range
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            min = 1;                 //reset the min value
            max = 1000;              //reset the max value
            guess = (min + max) / 2; //reset the guess value
            StartGame();
        }
	}

    //This is just for simplifying and cleaning up repeating code above
    void NextGuess ()
    {
        guess = (max + min) / 2;
        print("Is the number higher or lower than " + guess + "?");
        print("Press the up arrow for higher than, down arrow for less than and Return for equal to.");
    }
}
