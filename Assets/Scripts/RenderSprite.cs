using UnityEngine;
using System.Collections;

public class RenderSprite : MonoBehaviour {

	public static bool startAnimation = false;
	public static bool jump = false;
	public static bool death = false;

	public Sprite[] sprites;
	public float fps;
	int numberOfFrames = 3;
	int jumpFrame = 3;
	int jumpLastHowManyFrames = 4;

	SpriteRenderer spriteRenderer;

	//public float x;
	//public float y;
	
	// Use this for initialization
	void Start (){
		transform.position = new Vector3(GameObject.Find("Koi").transform.position.x, GameObject.Find("Koi").transform.position.y, -1.0f);
		spriteRenderer = renderer as SpriteRenderer;
	}
	
	// Update is called once per frame
	int indexState;
	bool didRecordIndexState = false;
	int count = 0;						
	void Update (){
		if(death){
			spriteRenderer.sprite = sprites[jumpFrame];
		}
		else{
			if(startAnimation){
				int index = (int)(Time.timeSinceLevelLoad * fps);
				index = index % numberOfFrames;

				if(jump){
					if(!didRecordIndexState){
						indexState = index;
						didRecordIndexState = true;
						spriteRenderer.sprite = sprites[jumpFrame];
					}
					// keep the jump frame time equal with the other frames' time
					else if(indexState != index){
						if( (++count) != jumpLastHowManyFrames )
							indexState = index;
						else{
							count = 0;
							jump = false;
							didRecordIndexState = false;
							spriteRenderer.sprite = sprites[index];
						}
					}
					else
						spriteRenderer.sprite = sprites[jumpFrame];
				}
				else
					spriteRenderer.sprite = sprites[index];
			}
			else
				spriteRenderer.sprite = sprites[0];
		}
	}
}
