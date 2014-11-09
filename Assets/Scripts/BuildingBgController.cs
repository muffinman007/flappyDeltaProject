using UnityEngine;
using System.Collections;

public class BuildingBgController : MonoBehaviour {

	public static bool startMoving = false;
	bool setOneTime = false;
	bool createOnce = false;
	// Use this for initialization
	void Start (){
		//rigidbody2D.velocity = new Vector2(-0.06f, 0.0f);
	}
	
	// Update is called once per frame
	void Update (){
		if(startMoving){
			if(!setOneTime){
				rigidbody2D.velocity = new Vector2(-0.06f, 0.0f);
				setOneTime = true;
			}

			if(transform.position.x <= -6.36f){
				if(!createOnce){
					createOnce = true;
					Instantiate(Resources.Load<GameObject>("BuildingBg"), new Vector3(6.42f, 0.0f, 0.0f), Quaternion.identity);
				}
			}
			 
			// destory self
			if(transform.position.x <= -12.84)
				Destroy(gameObject);
		}
	}
}
