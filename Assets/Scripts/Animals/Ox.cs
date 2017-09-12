using UnityEngine;

public class Ox : Animal
{
	[SerializeField] private float _specialAttackRadius;
	[SerializeField] private float _power;
		
	protected override void SpecialAttack()
	{
		print("special attack");
		var obstacles = GameObject.FindGameObjectsWithTag ("Obstacle");
		foreach (var obj in obstacles)
		{
			var distance = Vector2.Distance(gameObject.transform.position, obj.transform.position);
			if (!(distance < _specialAttackRadius)) continue;
			print(obj.name);
			if (obj.GetComponent<ClashBlock>() != null)
			{
				obj.GetComponent<ClashBlock>().ForceToObject(gameObject.transform.position, _power);
			}
		}
	}
}
