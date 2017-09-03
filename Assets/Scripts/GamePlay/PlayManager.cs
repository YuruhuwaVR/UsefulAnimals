using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;


public class PlayManager : SingletonMonoBehaviour<PlayManager>
{

	//private Stage _stage;
	public GameObject _currentAnimal;

	public Phase GameStatus;

	public enum Phase 
	{
		Start,
		Select,
		Ready,
		Flying
	}

	public int _currentCost;
	private bool _specialAttack; //これAnimalクラス？？
	
	

	// Use this for initialization
	void Start ()
	{
		GameStatus = Phase.Start;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GameClear()
	{
		//ゲームクリアしたときの処理
	}

	void GameRestart()
	{
		//リスタートするときの処理
		GameStatus = Phase.Select;
	}

	void GameFail()
	{
		//ゲームに失敗した時の処理
	}

	void Check()
	{
		//Animalが当たってクリアかどうか判定
	}
	
}
