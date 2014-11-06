using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public GUISkin skin;

	void OnGUI()
	{
		GUI.skin = skin;
		if (GUI.Button(new Rect(camera.pixelWidth/4f,camera.pixelHeight/2.5f,
		                        camera.pixelWidth/8,camera.pixelHeight/15),
		               			"Play", skin.GetStyle("buttonBackground")))
		    Application.LoadLevel("GamePlay");

		if (GUI.Button(new Rect(camera.pixelWidth/4f,camera.pixelHeight/2.5f + (50),
		                        camera.pixelWidth/8,camera.pixelHeight/15),"Quit",
		               			skin.GetStyle("buttonBackground")))
			Application.Quit();

		if (GUI.Button(new Rect(camera.pixelWidth/4f,camera.pixelHeight/2.5f + (100),
		                        camera.pixelWidth/8,camera.pixelHeight/15),"Credit",
		               			skin.GetStyle("buttonBackground")))
			Application.LoadLevel("Credit");
	}
}
