using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thicket : ClashBlock {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//通常
	private void SetDefault()
	{
		gameObject.layer = LayerMask.NameToLayer("Default");
	}

	//ウマの必殺技のとき
	public void ChangeLayer()
	{
		gameObject.layer = LayerMask.NameToLayer("ThroughTreeLayer");
		Hp = 0;
	}
}
