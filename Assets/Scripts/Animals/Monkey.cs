using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : Animal
{

	[SerializeField] private GameObject _monkey;
	[SerializeField] private float _power;

	protected override void SpecialAttack()
	{
		//必殺技
		GameObject instantiateMonkey1 = Instantiate(_monkey);
		var transformPosition = instantiateMonkey1.transform.position;
		transformPosition.x = gameObject.transform.position.x;
		float yPosition = gameObject.transform.position.y;
		transformPosition.y = yPosition + 5f;
		instantiateMonkey1.transform.position = transformPosition;
		instantiateMonkey1.transform.rotation = transform.rotation;
		instantiateMonkey1.GetComponent<Rigidbody2D>().AddForce(Direction.normalized*_power);
		
		GameObject instantiateMonkey2 = Instantiate(_monkey);
		var transformPosition2 = instantiateMonkey2.transform.position;
		transformPosition2.x = gameObject.transform.position.x;
		transformPosition2.y = yPosition - 5f;
		instantiateMonkey2.transform.position = transformPosition2;
		instantiateMonkey2.transform.rotation = transform.rotation;
		instantiateMonkey2.GetComponent<Rigidbody2D>().AddForce(Direction.normalized*_power);
		
	}
}
