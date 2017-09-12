using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cock : Animal
{

	[SerializeField] private GameObject _egg;
	[SerializeField] private int eggNum;

	protected override void SpecialAttack()
	{
		//必殺技
		for (int i = 0; i < eggNum; i++)
		{
			Instantiate(_egg, gameObject.transform.position, Quaternion.identity);
		}
	}
}
