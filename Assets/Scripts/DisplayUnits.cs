using UnityEngine;
using System.Collections;

public class DisplayUnits : MonoBehaviour {

	// Use this for initialization
	void Start (){
		guiText.text = "Units: " + GameObject.FindGameObjectWithTag("Koi").GetComponents<PlayerController>()[0].Unit;
		
	}
	
	// Update is called once per frame
	void Update (){
		guiText.text = "Units: " + GameObject.FindGameObjectWithTag("Koi").GetComponents<PlayerController>()[0].Unit;	
	}
}
