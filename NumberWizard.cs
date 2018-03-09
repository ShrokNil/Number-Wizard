using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;
	
	void Start () {
		StartGame ();
		NextGuess ();
	}
	
	void StartGame() {
		max = 10000;
		min = 1;
		guess = 5000;
	
		
	
	print ("========================");
	print ("Welcome To Number Wizard");
	print ("Pick a number in your head, but don't tell me!");	
	
	print ("The highest number you can pick is " + max);
	print ("The lowest number you can pick is "	+ min);
	
	print ("Is the number higher or lower than " + guess );
	
	
	
	}
	

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {		
			min = guess +1;
			NextGuess ();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {			
			max = guess + 1;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) {
			print ("I won!");
		StartGame ();
		
	}
	} 	
	void NextGuess() {
		guess = Random.Range (min,max);
		print ("Higher or lower than " + guess);
		print ("Up arrow = higher, down arrow = lower, return = equal");
	}
	
	}
	 
 