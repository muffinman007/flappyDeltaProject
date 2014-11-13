using UnityEngine;
using System.Collections;

public class Credit : MonoBehaviour {
	public GUISkin skin;
	float y = Screen.height;
	float yAdder;

	void Start()
	{
		yAdder = y;
	}

	void Update()
	{
		if (Input.GetButtonDown("Escape"))
			Application.LoadLevel("MainMenu");
	}

	void OnGUI()
	{
		GUI.skin = skin;

		GUI.Label(new Rect(   GameObject.Find("Main Camera").camera.pixelWidth/12, y,
		                 GameObject.Find("Main Camera").camera.pixelWidth - (GameObject.Find("Main Camera").camera.pixelWidth/10)*1.7f,
		                 GameObject.Find("Main Camera").camera.pixelHeight - (GameObject.Find("Main Camera").camera.pixelHeight/10)*1.7f),
		        "Credit\nFLAPPY DELTA",
		        skin.GetStyle("credit"));
			
		GUI.Box(new Rect(GameObject.Find("Main Camera").camera.pixelWidth/12, y + (yAdder / 1.5f),
		                 GameObject.Find("Main Camera").camera.pixelWidth - (GameObject.Find("Main Camera").camera.pixelWidth/10)*1.7f,
		                 GameObject.Find("Main Camera").camera.pixelHeight - (GameObject.Find("Main Camera").camera.pixelHeight/2f)),
		          		 "", skin.GetStyle("creditPic"));

		GUI.Label(new Rect( GameObject.Find("Main Camera").camera.pixelWidth/12, y + (yAdder *1.5f),
		                   GameObject.Find("Main Camera").camera.pixelWidth - (GameObject.Find("Main Camera").camera.pixelWidth/10)*1.7f,
		                   GameObject.Find("Main Camera").camera.pixelHeight - (GameObject.Find("Main Camera").camera.pixelHeight/10)*1.7f),
		          "GUI Programmer: \nNorlan Prudente\n\n Lead Programmer: \nMinh Pham\n\nCollision Programmer: \nMichael Runyon" +
		          "\n\nArt:\nKenneth Fujimura \n\nMusic:\nBrian Jenner \n\nCredit: \nHou Vhang\nJossue Medina",
		          skin.GetStyle("names"));

		GUI.Box(new Rect(GameObject.Find("Main Camera").camera.pixelWidth/1.4f, y + (yAdder * 2.5f),
		                 GameObject.Find("Main Camera").camera.pixelWidth - (GameObject.Find("Main Camera").camera.pixelWidth/1.4f),
		                 GameObject.Find("Main Camera").camera.pixelHeight - (GameObject.Find("Main Camera").camera.pixelHeight/2f)),
		        "", skin.GetStyle("creditPic2"));

		GUI.Label(new Rect(GameObject.Find("Main Camera").camera.pixelWidth/4f, y + (yAdder * 2.5f),
		                 GameObject.Find("Main Camera").camera.pixelWidth - (GameObject.Find("Main Camera").camera.pixelWidth/2f),
		                 GameObject.Find("Main Camera").camera.pixelHeight - (GameObject.Find("Main Camera").camera.pixelHeight/2f)),
		        "Thank\nYou!!!", skin.GetStyle("names"));
		if (y > -(yAdder * 2.5f))
			y -= 0.5f;
	}
}
