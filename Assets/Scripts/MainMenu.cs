using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnGUI()
	{
		if (GUI.Button(new Rect(Screen.width/4f,Screen.height/2.85f,Screen.width/8,Screen.height/15),"Play"))
		    Application.LoadLevel("GamePlay");

		if (GUI.Button(new Rect(Screen.width/4f,Screen.height/1.5f,Screen.width/8,Screen.height/15),"Quit"))
			Application.Quit();

		if (GUI.Button(new Rect(Screen.width/4f,(Screen.height/1.5f) + 50,Screen.width/8,Screen.height/15),"Credit"))
			Application.LoadLevel("Credit");
	}
}
