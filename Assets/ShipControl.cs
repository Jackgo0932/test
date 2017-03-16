using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShipControl : MonoBehaviour {
	public GameObject Bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)&&gameObject.transform.position.x<3.5f) {
			gameObject.transform.position += new Vector3(0.1f,0,0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)&&gameObject.transform.position.x>-3.5f) {
			gameObject.transform.position += new Vector3(-0.1f,0,0);
		}
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			Vector3 pos = gameObject.transform.position + new Vector3(0,1.2f,0);
			Instantiate(Bullet,pos,gameObject.transform.rotation);
			}
	}
}
