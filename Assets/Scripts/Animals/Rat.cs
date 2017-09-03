using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using unirx;

public class Rat : Animal
{

	private TrailRenderer _trail;
	private Vector3 _startPosition;
	private TrailRenderer _trailRenderer;
	private Rigidbody2D _rigidbody2D;

	// Use this for initialization
	void Start()
	{
		SetValue(1, 10, 100, 1000);
		_startPosition = gameObject.transform.position;
		_trailRenderer = gameObject.GetComponent<TrailRenderer>();
		_rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		if (_startPosition == null) return;
		//if (gameObject.transform.position.x > _startPosition.x)
		if (PlayManager.instance.GameStatus == PlayManager.Phase.Flying && gameObject.transform.position.x > _startPosition.x)
		{
			_trailRenderer.enabled = true;
			_rigidbody2D.bodyType = RigidbodyType2D.Dynamic;

			if (_rigidbody2D.velocity.x == 0)
			{
				DestroyObject(gameObject, 3);
				Observable.Timer(TimeSpan.FromSeconds(2))
					.Subscribe(_ => PlayManager.instance.GameStatus = PlayManager.Phase.Ready;);

			}
		}
	}



	protected override void SpecialAttack()
	{
		//必殺技の処理
	}
}
