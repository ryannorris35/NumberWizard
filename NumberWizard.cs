using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int maximum;
    int minimum;
    int guess;


    // Start is called before the first frame update
    void Start()
    {
    StartGame();
    }

        void StartGame()
    {
     maximum = 1000;
     minimum = 1;
     guess = 500;

     Debug.Log("Croes i number Wizard");
     Debug.Log("Pick a Number, keep this to yourself for now");   
     Debug.Log("The Highest number you can pick is : " +maximum);
     Debug.Log("The Lowest number you can pick is : " +minimum);
     Debug.Log ("Tell me if you are number is higher or lower than " + guess);
     Debug.Log ("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
     maximum = maximum + 1;
    }

    // Update is called once per frame
    void Update ()
    {
      if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minimum = guess;
            NextGuess();
  
        }
       else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maximum = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("One is a genius!");
            StartGame();
        }
    }
    void NextGuess ()
    {
        guess = (maximum + minimum) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
}
