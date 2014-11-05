using UnityEngine;
using System.Collections;

public class TextureRes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.transform.localScale = new Vector3 (GameObject.Find ("MainCamera").transform.localScale.x, GameObject.Find ("MainCamera").transform.localScale.y, 0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
