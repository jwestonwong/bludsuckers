using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightTimer : MonoBehaviour {

	bool Night = true;
	float startTime = 0;
	float elapsedTime = 0;

	// Use this for initialization
	void Start () {

		startTime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {

		elapsedTime = Time.time - startTime;
		//print (elapsedTime);
		//print (Time.time);
		//print (startTime);

		//This if statment controls how long the day/night phase is. Currently it is given equal weighting,
		//but it can be changed to be asymetrical. Changing the integer below changes how long the day/night
		//is in seconds.
		if (elapsedTime > 5) {
			if (Night == true) {
				Night = false;
				print ("Day");
				startTime = Time.time;
			}
			else if (Night == false) {
				Night = true;
				print ("Night");
				startTime = Time.time;
			}
		}

	}
		
}
