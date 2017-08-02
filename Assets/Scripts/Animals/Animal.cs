using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{

	[SerializeField] protected int Id;
	[SerializeField] protected int Weight;
	[SerializeField] protected int Movespeed;
	[SerializeField] protected int AttackPower;

	protected void SetValue(int id, int weight, int movespeed, int attackpower)
	{
		Id = id;
		Weight = weight;
		Movespeed = movespeed;
		AttackPower = attackpower;
	}

	protected abstract void SpecialAttack();
}
