using UnityEngine;
using System.Collections;

public class GenerateScript : MonoBehaviour {

	public GameObject rocks;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 1f);
	}
	
	void CreateObstacle()
	{
		Instantiate(rocks);
	}
}
