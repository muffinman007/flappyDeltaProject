using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnGUI()
	{
		if (GUI.Button(new Rect(Screen.width/4f,Screen.height/2.85f,Screen.width/8,Screen.height/15),"Play"))
		    Application.LoadLevel("GamePlay");
	}
}
