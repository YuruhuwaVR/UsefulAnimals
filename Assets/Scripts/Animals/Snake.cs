using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : Animal
{

	[SerializeField] private float _power;

	protected override void SpecialAttack()
	{
		//必殺技
		Vector2 direction = new Vector2(-1.0f, 0.8f);
		gameObject.GetComponent<Rigidbody2D>().AddForce(direction * _power);
		
	}
}
