using UnityEngine;
using System.Collections;

public class GenerateScript : MonoBehaviour {

	public GameObject pipes;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 1f);
	}
	
	void CreateObstacle()
	{
		//This creates and destroys the pipes after 5 seconds
		GameObject clone = (GameObject)Instantiate (pipes, transform.position, Quaternion.identity);
		Destroy (clone, 5.0f);
	}
}
