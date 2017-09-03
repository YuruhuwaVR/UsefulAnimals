using UnityEngine;

public abstract class Animal : MonoBehaviour
{

	[SerializeField] public int Id;
	[SerializeField] public int Cost;
	[SerializeField] public string Name;
	[SerializeField] public int Hp;
	[SerializeField] public int Weight;
	[SerializeField] public int Movespeed;

	
	protected abstract void SpecialAttack();

	void OnCollisionEnter2D(Collision2D other)
	{
		if (GetComponent<ClashBlock>() == null) return;
		int damage = other.collider.gameObject.GetComponent<ClashBlock>().AttackPower;
		Hp -= damage;
	}

	protected void Dead()
	{
		if (Hp < 0)
		{
			Destroy(gameObject);
		}
	}
}
