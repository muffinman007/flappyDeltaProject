using UnityEngine;
using System.Collections;

public class UnitTokenRender : MonoBehaviour{

	public Sprite[] sprites;
	SpriteRenderer spriteRenderer;

	public int fps;
	float timer = 0.0f;
	public float timerLimit = 1.5f;		// time between each animation

	public int playHowManyTime = 2;     // play the animation how many times
	int playCounter = 0;
	
	// Use this for initialization
	void Start (){
		spriteRenderer = renderer as SpriteRenderer;
	}
	
	// Update is called once per frame
	void Update (){
		timer += Time.deltaTime;

		if(timer >= timerLimit){
			int index = ((int)(timer * fps)) % sprites.Length;
			
			if(index == 0)
				++playCounter;
			
			if( !(playCounter > playHowManyTime) )
				spriteRenderer.sprite = sprites[index];
			else{
				spriteRenderer.sprite = sprites[0];
				playCounter = 0;
				timer = 0.0f;
			}
		}
		else
			spriteRenderer.sprite = sprites[0];
	}



}
