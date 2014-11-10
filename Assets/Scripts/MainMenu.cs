using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainMenu : MonoBehaviour {
	public GUISkin skin;

	public AudioClip secretSFX;

	List<KeyCode> secretCode = new List<KeyCode>(){ KeyCode.UpArrow, KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.DownArrow, 
													KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.LeftArrow, KeyCode.RightArrow,
													KeyCode.B, KeyCode.A};

	List<KeyCode> keyPressed = new List<KeyCode>();

	bool getSecretCode = true;
	bool codeActiviated = false;
	int keyEnteredCorrectly = 0;
	
	void OnGUI()
	{
		if(getSecretCode){
			Event e = Event.current;
			if(e.isKey){
				if(keyPressed.Contains(e.keyCode)){
					if(e.keyCode.ToString() != "None")
						if(e.keyCode == secretCode[keyEnteredCorrectly]){
							++keyEnteredCorrectly;
							//Debug.Log(keyEnteredCorrectly);
							if(keyEnteredCorrectly == secretCode.Count){
								audio.PlayOneShot(secretSFX);
								PlayerController.gamePlayMode = PlayerController.GamePlayMode.KONAMI;
								getSecretCode = false;
								codeActiviated = true;
							}
						}
						else
							keyEnteredCorrectly = 0;

					keyPressed.Remove(e.keyCode);
				}
				else
					keyPressed.Add(e.keyCode);
			}
		}

		GUI.skin = skin;

		GUI.Label(new Rect( 80,
			                10,
			                GameObject.Find("Main Camera").camera.pixelWidth - 20,
			                50),
			        	   "Flappy Delta",
			        	   skin.GetStyle("title"));

		// easy play
		if(GUI.Button(new Rect( 40, 210,
		                        120, GameObject.Find("Main Camera").camera.pixelHeight/15),
		               			"Easy Play", skin.GetStyle("buttonBackground"))){
			if(!codeActiviated)
				PlayerController.gamePlayMode = PlayerController.GamePlayMode.EASY;
		    Application.LoadLevel("GamePlay");
		}

		// normal play
		if(GUI.Button(new Rect( 40, 210 + (GameObject.Find("Main Camera").camera.pixelHeight/15) + 10,
		                        120, GameObject.Find("Main Camera").camera.pixelHeight/15),
		               			"Normal Play", skin.GetStyle("buttonBackground"))){
			if(!codeActiviated)
				PlayerController.gamePlayMode = PlayerController.GamePlayMode.NORMAL;
		    Application.LoadLevel("GamePlay");
		}

		
		if(GUI.Button(new Rect( 350, 340,
		                        120, GameObject.Find("Main Camera").camera.pixelHeight/15),
								"Quit",	skin.GetStyle("buttonBackground")))
			Application.Quit();

		if(GUI.Button(new Rect( 350, 210,
		                        120, GameObject.Find("Main Camera").camera.pixelHeight/15),
								"Credit", skin.GetStyle("buttonBackground")))
			Application.LoadLevel("Credit");
	}
}
