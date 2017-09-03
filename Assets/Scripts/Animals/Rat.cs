using System;
using System.CodeDom;
using UniRx;
using UnityEngine;

public class Rat : Animal
{
	private bool _useable;
	
	// Use this for initialization
	void Start()
	{
		_useable = true;
	}

	// Update is called once per frame
	void Update()
	{
		Dead();

		if (PlayManager.instance.GameStatus == PlayManager.Phase.Flying && Input.GetMouseButton(0) && _useable)
		{
			SpecialAttack();
			_useable = false;
		}
	}



	protected override void SpecialAttack()
	{
		//必殺技の処理
		print("rat special attack");
	}
}
