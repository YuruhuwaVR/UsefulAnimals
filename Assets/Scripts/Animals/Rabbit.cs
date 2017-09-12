using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : Animal
{
	[SerializeField] private float _power; 
	protected override void SpecialAttack()
	{
		//必殺技
		gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up*_power);
	}
}

