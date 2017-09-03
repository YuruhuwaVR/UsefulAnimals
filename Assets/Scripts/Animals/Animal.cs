using UnityEngine;

public abstract class Animal : MonoBehaviour
{

	[SerializeField] protected int Id;
	[SerializeField] public int Cost;
	[SerializeField] public string Name;
	[SerializeField] public int Weight;
	[SerializeField] protected int Movespeed;
	[SerializeField] protected int AttackPower;
	


	protected abstract void SpecialAttack();


}
