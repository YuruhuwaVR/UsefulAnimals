using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : ClashBlock {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayManager.instance.GameStatus == PlayManager.Phase.Select)
		{
			SetDefault();
		}
	}
	
	//通常
	private void SetDefault()
	{
		gameObject.layer = LayerMask.NameToLayer("Default");
	}

	//ねずみの必殺技のとき
	public void ChangeLayer()
	{
		gameObject.layer = LayerMask.NameToLayer("ThroughTreeLayer");
	}
}
