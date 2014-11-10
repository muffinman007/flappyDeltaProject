using UnityEngine;
using System.Collections;

public class GenerateScript : MonoBehaviour {

	//public GameObject pipes;
	public float repeatTime = 0.98f;	
	

	float token_yOffset = 0.5f;

	// ideal lowest point of the top of the bottom book is y = -1.9f
	// ideal highest point of the bottom of the top book is y = 6.7
	// the top book effects the placement of the bottom book so rangeMin and rangeMax is for the placement of the top book.
	// numbers set relative to the location of the GenerateBooksAndTokens whose coordinate is y = 0 while x equal to the right size of the viewport
	float rangeMin = 5.2f;
	float rangeMax = 6.5f; 

	//distance between books
	float distBetweenBooks = 6.7f;


	void Start()
	{
		repeatTime = 1.5f * (45 * Time.deltaTime);
		InvokeRepeating("CreateObstacle", 0.22f , repeatTime);
	}
	
	void CreateObstacle()
	{
		//This creates and destroys the pipes after 2 seconds
		// edit code: create function should not have the ablity to destory object
		// instead add collision detection to object for destruction.
		float y = Random.Range (rangeMin, rangeMax);
		//Object aBook = AssetDatabase.LoadAssetAtPath("Assets/prefabs/Book.prefab", typeof(GameObject));
		//Object aToken = AssetDatabase.LoadAssetAtPath("Assets/prefabs/Token.prefab", typeof(GameObject));

		// Top book
		Instantiate( Resources.Load<GameObject>("Book"),
					 new Vector3(transform.position.x, transform.position.y + y, 0),
					 Quaternion.identity);

		// bottom book
		Instantiate( Resources.Load<GameObject>("Book"), 
					 new Vector3(transform.position.x, transform.position.y + y - distBetweenBooks, 0),
					 Quaternion.identity);
					
		// generate token either near the top book or near the bottom book
		// magic number 4.15 = (height of shinyToken.png * .25(scale) + height of the book sprit) * ratio of pixel to unity coordinate unit (about 0.01 for pixel)
		//if( (Random.Range(0, 2)) == 0 )
			Instantiate( Resources.Load<GameObject>("Token"), 
						 new Vector3(transform.position.x, transform.position.y + y + token_yOffset - (4.15f + (distBetweenBooks/3.2f)), 0), 
						 Quaternion.identity);
		//else
			//Instantiate(aToken, 
						//new Vector3(transform.position.x, transform.position.y + y - distBetweenBooks - token_yOffset, 0),
						//Quaternion.identity);
							
		
		//Destroy (clone, (2.0f + (45 * Time.deltaTime)));
	}
}
