using System;
using UniRx;
using UnityEngine;

public class Rat : Animal
{

//	private TrailRenderer _trail;
//	private Vector3 _startPosition;
//	private TrailRenderer _trailRenderer;
	private Rigidbody2D _rigidbody2D;
//	private Boolean _velocityFlag = true;
	

//	// Use this for initialization
	void Start()
	{
		
	}

//	// Update is called once per frame
//	void Update()
//	{
//		if (_startPosition == null) return;
//		if (PlayManager.instance.GameStatus == PlayManager.Phase.Flying && gameObject.transform.position.x > _startPosition.x)
//		{
//			_trailRenderer.enabled = true;
//			_rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
//
//			if (_rigidbody2D.velocity.x < 0.5 && _velocityFlag )
//			{
//				_velocityFlag = false;
//				DestroyObject(gameObject, 3);
//				Observable.Timer(TimeSpan.FromSeconds(2))
//					.Subscribe(_ => PlayManager.instance.GameStatus = PlayManager.Phase.Ready);
//
//			}
//		}
//	}



	protected override void SpecialAttack()
	{
		//必殺技の処理
	}
}
