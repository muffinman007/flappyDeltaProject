using UnityEngine;
using System.Collections;

public class DisplayRetake : MonoBehaviour {

	// Use this for initialization
	void Start (){
		guiText.text = "Retake: " + GameObject.FindGameObjectWithTag("Koi").GetComponents<PlayerController>()[0].Lives;
		
	}
	
	// Update is called once per frame
	void Update (){
		guiText.text = "Retake: " + GameObject.FindGameObjectWithTag("Koi").GetComponents<PlayerController>()[0].Lives;	
	}
}
