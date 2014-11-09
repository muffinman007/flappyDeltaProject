using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int Unit{ get; private set; }

	//The force that is added when the player jumps.
	Vector2 jumpForce = new Vector2(0, 305);
	bool gravityOn = false;

	float gravity = 1.58f;

	bool isGeneratingBookToken = false;
	bool startBuildingBgMovement = false;
	void Start(){
		Unit = 0;
	}

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
				rigidbody2D.gravityScale = gravity;
			}

			if(!isGeneratingBookToken){
				isGeneratingBookToken = true;
				Instantiate(Resources.Load<GameObject>("GenerateBooksAndTokens"));
			}

			if(!startBuildingBgMovement){
				startBuildingBgMovement = true;
				BuildingBgController.startMoving = true;
				RenderSprite.startAnimation = true;
			}

			// the koi fish jump animation
			RenderSprite.jump = true;
		}

		//die from falling off screen
		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) 
		{
			//Death();		
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		//Death();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.tag == "token"){
			Unit += 1;
		}
	}

	
	void Death()
	{
		Application.LoadLevel ("GameOver");
	}




}
