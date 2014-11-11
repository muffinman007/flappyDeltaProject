using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public GUISkin skin;
	
	public static int unit;

	float timer = 0.0f;
	float timePaused = .70f;
	float showButtonTime = 1.5f;
	bool setTimer = true;

	bool showText = false;
	bool showButton = false;
	void Start(){
	}

	void Update(){

		if(setTimer){
			timer += Time.realtimeSinceStartup / 1000.0f;

			if(timer >= timePaused)
				showText = true;

			if(timer >= showButtonTime){
				showButton = true;
				setTimer = false;
			}
		}
	}


	void OnGUI()
	{
		if(showText){
			GUI.skin = skin;
		
			GUI.Box(new Rect(   GameObject.Find("Main Camera").camera.pixelWidth/12, GameObject.Find("Main Camera").camera.pixelHeight/12,
								GameObject.Find("Main Camera").camera.pixelWidth - (GameObject.Find("Main Camera").camera.pixelWidth/10)*1.7f,
								GameObject.Find("Main Camera").camera.pixelHeight - (GameObject.Find("Main Camera").camera.pixelHeight/10)*1.7f),
			        			"THE UNIVERSITY BEHIND TARGET\nCongratulation!",
			        			skin.GetStyle("gameOver"));
		

			GUI.Label(new Rect( GameObject.Find("Main Camera").camera.pixelWidth/12, GameObject.Find("Main Camera").camera.pixelHeight/2,
								GameObject.Find("Main Camera").camera.pixelWidth - (GameObject.Find("Main Camera").camera.pixelWidth/10)*1.7f,
								GameObject.Find("Main Camera").camera.pixelHeight - (GameObject.Find("Main Camera").camera.pixelHeight/10)*1.7f),
								"This here confers upon you the degree of\n" +
								"Doctor of Flappy-ology\ntogether with all the rights, privileges and honors appertaining thereto in consideration of the satisfactory completion of the course prescribed in \n" +
								"The Graduate School\nwith the total units of\n" +
			          			unit + " unit(s)",
			          			skin.GetStyle("message"));
		}

		if(showButton){
			// normal play
			if(GUI.Button(new Rect( GameObject.Find("Main Camera").camera.pixelWidth/12, 335,
									120, GameObject.Find("Main Camera").camera.pixelHeight/15),
		               				"Play Again", skin.GetStyle("buttonBackground"))){
				Application.LoadLevel("MainMenu");
			}

		
			if(GUI.Button(new Rect( GameObject.Find("Main Camera").camera.pixelWidth - (GameObject.Find("Main Camera").camera.pixelWidth/12) - 120, 335,
									120, GameObject.Find("Main Camera").camera.pixelHeight/15),
									"Quit",	skin.GetStyle("buttonBackground")))
				Application.Quit();

			}

	}
}
