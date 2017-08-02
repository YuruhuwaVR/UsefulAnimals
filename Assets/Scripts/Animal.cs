using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{

	[SerializeField] protected int Id;
	[SerializeField] protected int Weight;
	[SerializeField] protected int Movespeed;
	[SerializeField] protected int AttackPower;

	protected abstract void SpecialAttack();
}
