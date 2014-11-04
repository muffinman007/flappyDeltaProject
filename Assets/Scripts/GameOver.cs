using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	bool gameOver = true;

	void OnGUI()
	{
		if(gameOver)
			GUI.Box(new Rect(camera.pixelWidth/12, camera.pixelHeight/12,camera.pixelWidth - (camera.pixelWidth/10)*1.7f,camera.pixelHeight - (camera.pixelHeight/10)*1.7f), "Game Over");

	}
}
