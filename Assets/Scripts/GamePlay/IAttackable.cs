using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attackable
{
	[SerializeField] private int _attackPower;
	public abstract int AttackPower { get; }
}