using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int maximum =1000;
    int minimum =1;
    int guess = 500;


    // Start is called before the first frame update
    void Start()
    {
 

     Debug.Log("Welcome to number Wizard");
     Debug.Log("Pick a Number, keep this to yourself for now");   
     Debug.Log("The Highest number you can pick is : " +maximum);
     Debug.Log("The Lowest number you can pick is : " +minimum);
     Debug.Log ("Tell me if you are number is higher or lower than 500");
     Debug.Log ("Push Up = Higher, Push Down = Lower, Push Enter = Correct");

    }

    // Update is called once per frame
    void Update ()
    {
      if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            minimum = guess;
            Debug.Log(guess);
        }
       else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
             maximum = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
        }
    }
}
