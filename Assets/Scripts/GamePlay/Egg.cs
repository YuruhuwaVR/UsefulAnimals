using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{

	private int _hp;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (_hp < 0)
		{
			Destroy(gameObject);
		}
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.GetComponent<ClashBlock>() == null) return;
		int damage = other.collider.gameObject.GetComponent<ClashBlock>().AttackPower;
		_hp -= damage;
	}
}
