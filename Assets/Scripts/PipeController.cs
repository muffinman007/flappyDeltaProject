using UnityEngine;
using System.Collections;

public class PipeController : MonoBehaviour {

	public Vector2 velocity = new Vector2(-4, 0);
	
	// Use this for initialization
	void Start()
	{
		rigidbody2D.velocity = velocity;
	}

	
	// Destory self after going off the screen and colliding with DestructDetector
	void OnTriggerEnter2D(Collider2D col){
		if(col.name == "DestructDetector")
			Destroy(gameObject);
	}


}
