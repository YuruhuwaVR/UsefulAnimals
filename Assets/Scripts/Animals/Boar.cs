using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Boar : Animal
{

	[SerializeField] private float _power;
	
	protected override void SpecialAttack()
	{
		//必殺技
		gameObject.GetComponent<Rigidbody2D>().AddForce(Direction * _power);
	}
}
