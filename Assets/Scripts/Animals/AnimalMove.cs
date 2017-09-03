using System;
using UniRx;
using UnityEngine;

public class AnimalMove : MonoBehaviour {

	private TrailRenderer _trail;
	private Vector3 _startPosition;
	private TrailRenderer _trailRenderer;
	private Rigidbody2D _rigidbody2D;
	private Boolean _velocityFlag = true;
	

	// Use this for initialization
	void Start()
	{
		_startPosition = gameObject.transform.position;
		_trailRenderer = gameObject.GetComponent<TrailRenderer>();
		_trailRenderer.enabled = false;
		_rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		if (_startPosition == null) return;
		if (PlayManager.instance.GameStatus == PlayManager.Phase.Flying && gameObject.transform.position.x > _startPosition.x)
		{
			_trailRenderer.enabled = true;
			_rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
			_rigidbody2D.mass = GetComponent<Animal>().Weight;

			if (_rigidbody2D.velocity.x < 0.5 && _velocityFlag )
			{
				_velocityFlag = false;
				DestroyObject(gameObject, 5);
				Observable.Timer(TimeSpan.FromSeconds(5))
					.Subscribe(_ => PlayManager.instance.GameStatus = PlayManager.Phase.Ready);
			}
		}
	}
}
