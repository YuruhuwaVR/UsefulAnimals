using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiger : Animal
{

	[SerializeField] private float _attackableDistance;
	[SerializeField] private float _attackPower;

	protected override void SpecialAttack()
	{
		//必殺技
		var Obstacles = GameObject.FindGameObjectsWithTag ("Obstacle");
		foreach (var obj in Obstacles)
		{
			if (obj.GetComponent<Iron>() != null && CalcDistance(obj))
			{
				obj.GetComponent<Iron>().GetDamage(_attackPower);
			}
		}
	}

	private bool CalcDistance(GameObject obj)
	{
		var distance = Vector2.Distance(obj.transform.position, gameObject.transform.position);
		return distance < _attackableDistance;
	}
}
