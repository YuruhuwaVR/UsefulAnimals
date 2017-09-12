using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClashBlock : MonoBehaviour
{
	[SerializeField] public int AttackPower, Hp;
	[SerializeField] private GameObject m_Effect;
	
	private void OnCollisionEnter2D(Collision2D other)
	{
		//相対速度を取得
//		float damage = other.relativeVelocity.magnitude - m_Strength;
		float damage = other.relativeVelocity.magnitude;
		Hp -= (int)damage; 
		
		if (Hp < 0)
		{
			Destroy(gameObject);
			GameObject effect = GameObject.Instantiate(
				m_Effect,
				transform.position,
				Quaternion.identity);
			DestroyObject(effect, 1.5f);
		}
	}

	public void ForceToObject(Vector2 position, float power)
	{
		Vector2 direction;
		direction.x = gameObject.transform.position.x - position.x;
		direction.y = gameObject.transform.position.y - position.y;
		direction = direction.normalized;
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		rb.AddForce(direction*power, ForceMode2D.Impulse);
	}

	//Dragonによる攻撃
	public void AttackedByDragon(float power)
	{
		Hp -= (int) power;
	}

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{

	}
}
