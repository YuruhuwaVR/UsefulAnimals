using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : Animal {

	// Use this for initialization
	void Start () {
		
		SetValue(9,10,100,1000);
		transform.position = new Vector3(0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	protected override void SpecialAttack()
	{
		//必殺技
	}
}
