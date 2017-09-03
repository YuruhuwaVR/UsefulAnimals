using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ox : Animal
{

	[SerializeField] private PlayManager _playManager;
		
	// Use this for initialization
	void Start () {
		SetValue(2,10,100,1000);
//		transform.position = new Vector3(0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (_playManager.GameStatus == PlayManager.Phase.Flying)
		{
			gameObject.AddComponent<TrailRenderer>();
		}
	}


	protected override void SpecialAttack()
	{
		//必殺技
	}
}
