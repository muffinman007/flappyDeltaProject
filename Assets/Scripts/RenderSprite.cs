using UnityEngine;
using System.Collections;

public class RenderSprite : MonoBehaviour {

	public Sprite sprite;

	SpriteRenderer spriteRenderer;

	public float x;
	public float y;
	
	// Use this for initialization
	void Start (){
		transform.position = new Vector3(x, y, -1.0f);
		spriteRenderer = renderer as SpriteRenderer;
	}
	
	// Update is called once per frame
	void Update (){
		spriteRenderer.sprite = sprite;
	}
}
