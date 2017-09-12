using UnityEngine;

public abstract class Animal : MonoBehaviour
{

	[SerializeField] public int Id;
	[SerializeField] public int Cost;
	[SerializeField] public string Name;
	[SerializeField] public int Hp;
	[SerializeField] public int Weight;
	[SerializeField] public int Movespeed;
	private bool _useable;
	protected Vector2 Direction;
	private Vector2 _posPosition;
	
	// Use this for initialization
	void Start()
	{
		_useable = true;
		_posPosition = gameObject.transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		Direction.x = gameObject.transform.position.x - _posPosition.x;
		Direction.y = gameObject.transform.position.y - _posPosition.y;
		Direction = Direction.normalized;
		_posPosition = gameObject.transform.position;
		
		
		print(_useable);
		if (PlayManager.instance.GameStatus == PlayManager.Phase.Flying && Input.GetMouseButton(0) && _useable)
		{
			SpecialAttack();
			_useable = false;
		}		
		
		Dead();
	}
	
	protected abstract void SpecialAttack();

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.GetComponent<ClashBlock>() == null) return;
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
