﻿using UnityEngine;
using System.Collections;

public class bgController : MonoBehaviour {
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2(-0.03f, 0.0f);
	}
	
	// Update is called once per frame
	void Update (){
		// got the magic number by manually moving the object around the editor until i get the desired coordinates
		// magic numbers are multiple of .03
		// creating a new bg object
		if(transform.position.x <= -6.36f)
			Instantiate(Resources.Load<GameObject>("SkyBg"), new Vector3(6.42f, 0.0f, 0.0f), Quaternion.identity);
 
		// destory self
		if(transform.position.x <= -12.84)
			Destroy(gameObject);
	}
}
