using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public GUISkin skin;

	bool gameOver = true;
	int score = 0;

	void OnGUI()
	{
		GUI.skin = skin;

		if(gameOver)
		{
			GUI.Box(new Rect(camera.pixelWidth/12, camera.pixelHeight/12,
			                 camera.pixelWidth - (camera.pixelWidth/10)*1.7f,
			                 camera.pixelHeight - (camera.pixelHeight/10)*1.7f),
			        		 "Game Over\nCongratulation!",
			        		 skin.GetStyle("gameOver"));

			GUI.Label(new Rect(camera.pixelWidth/12, camera.pixelHeight/2,
			                   camera.pixelWidth - (camera.pixelWidth/10)*1.7f,
			                   camera.pixelHeight - (camera.pixelHeight/10)*1.7f),
					           "Here is your diploma from the UBT college.\nwith the total unit of\n" +
			          		   score.ToString() + " unit(s)",
			          		   skin.GetStyle("message"));
		}

	}
}
