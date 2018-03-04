using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Network.isServer)
		{
			Vector3 moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			float speed = 5;
			this.transform.Translate(speed * moveDir * Time.deltaTime);
		}
	}
}
