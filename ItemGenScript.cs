using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is a list I put together to test it. Once we have the full item list and desired weightings, we just
//edit it here, adding them to the list. We can use a state machine to control the effects of the items, I'll
//hopefully have the time to add that tonight.
public enum item {Stake, Garlic, Garlic_1, HolyWater, HolyWater_1, Trap, Trap2};

public class ItemGenScript : MonoBehaviour {

	item Item;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.I)) {
			print ("Key pressed");
			Item = (item)(UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(item)).Length));
			print (Item);
		}

	}
		
}
