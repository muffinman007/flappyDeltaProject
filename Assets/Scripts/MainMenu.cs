using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public GUISkin skin;

	void OnGUI()
	{
		GUI.skin = skin;

		GUI.Label(new Rect(camera.pixelWidth - (camera.pixelWidth - 90),
			               camera.pixelHeight - (camera.pixelHeight - 50),
			               camera.pixelWidth,
			               camera.pixelHeight - (camera.pixelHeight/1.15f)),
			        	   "Flappy\nDelta",
			        	   skin.GetStyle("title"));

		if (GUI.Button(new Rect(camera.pixelWidth/1.4f,camera.pixelHeight/2.3f,
		                        camera.pixelWidth/6,camera.pixelHeight/15),
		               			"Play", skin.GetStyle("buttonBackground")))
		    Application.LoadLevel("GamePlay");

		if (GUI.Button(new Rect(camera.pixelWidth/1.38f,camera.pixelHeight/2.3f + (60),
		                        camera.pixelWidth/10,camera.pixelHeight/12),"Quit",
		               			skin.GetStyle("buttonBackground")))
			Application.Quit();

		if (GUI.Button(new Rect(camera.pixelWidth/1.30f,camera.pixelHeight/1.5f,
		                        camera.pixelWidth/12,camera.pixelHeight/8),"Credit",
		               			skin.GetStyle("buttonBackground")))
			Application.LoadLevel("Credit");
	}
}
