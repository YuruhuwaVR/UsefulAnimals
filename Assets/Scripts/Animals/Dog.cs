using UnityEngine;

public class Dog : Animal
{

	[SerializeField] private float _power;
	private GameObject _target;
	private float _maxDistance;
	
	protected override void SpecialAttack()
	{
		//必殺技
		var targets = GameObject.FindGameObjectsWithTag ("Target");
		if(targets == null) return;
		foreach (var target in targets)
		{
			var targetPosition = target.transform.position;
			var distance = Vector2.Distance(gameObject.transform.position, targetPosition);
			if (_maxDistance < distance)
			{
				_maxDistance = distance;
				_target = target;
			}
		}
		var direction = (_target.gameObject.transform.position - gameObject.transform.position).normalized;
		gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
		gameObject.GetComponent<Rigidbody2D>().AddForce(direction * _power);
	}
}
