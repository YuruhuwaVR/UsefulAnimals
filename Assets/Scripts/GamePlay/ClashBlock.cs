using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClashBlock : MonoBehaviour
{
	[SerializeField] private float m_Strength, m_hp;
	[SerializeField] private GameObject m_Effect;

	private void OnCollisionEnter2D(Collision2D other)
	{
		//相対速度を取得
//		float damage = other.relativeVelocity.magnitude - m_Strength;
		float damage = other.relativeVelocity.magnitude;
//		print(damage);
		m_Strength -= damage; 
		
		if (m_Strength < 0)
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
