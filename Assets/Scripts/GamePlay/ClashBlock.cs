using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClashBlock : MonoBehaviour
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

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{

	}

	
}
