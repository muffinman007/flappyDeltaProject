using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//The force that is added when the player jumps.
	public Vector2 jumpForce = new Vector2(0, 300);
	bool gravityOn = false;



	// Update is called once per frame
	void Update () 
	{
		//jumping
		if (Input.GetKeyUp ("space")) 
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce (jumpForce);

			if(!gravityOn){
				gravityOn = true;
				rigidbody2D.gravityScale = 1f;
			}


		}

		//die from falling off screen
		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) 
		{
			Death();		
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Death();
	}

	void Death()
	{
		Application.LoadLevel ("GameOver");
	}
}
