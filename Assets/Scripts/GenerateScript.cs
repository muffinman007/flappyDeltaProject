using UnityEngine;
using System.Collections;

public class GenerateScript : MonoBehaviour {

	public GameObject pipes;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", (1f * (45 * Time.deltaTime)) , (1.5f * (45 * Time.deltaTime)));
	}
	
	void CreateObstacle()
	{
		//This creates and destroys the pipes after 2 seconds
		float y = Random.Range (0.6f, 1.2f);
		GameObject clone = (GameObject)Instantiate (pipes, transform.position + new Vector3(0, y ,0), Quaternion.identity);
		Destroy (clone, (2.0f + (45 * Time.deltaTime)));
	}
}
