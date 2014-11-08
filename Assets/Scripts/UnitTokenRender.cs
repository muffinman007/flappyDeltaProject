using UnityEngine;
using System.Collections;

public class UnitTokenRender : MonoBehaviour{

	public Sprite[] sprites;
	SpriteRenderer spriteRenderer;

	public int fps;
	float timer = 0.0f;
	public float timerLimit = 0.3f;		// time between each animation

	public int playHowManyTime = 2;     // play the animation how many times
	int playCounter = 0;
	
	float timeObjectStart;
	// Use this for initialization
	void Start (){
		timeObjectStart = Time.realtimeSinceStartup;
		spriteRenderer = renderer as SpriteRenderer;
	}
	
	// Update is called once per frame
	void Update (){
		timer += (Time.realtimeSinceStartup - timeObjectStart) / 1000.0f;

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
