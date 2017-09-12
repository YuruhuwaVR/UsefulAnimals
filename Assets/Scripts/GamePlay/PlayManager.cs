using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;


public class PlayManager : SingletonMonoBehaviour<PlayManager>
{

	//private Stage _stage;
	[SerializeField] private GameObject _stageClearPop;
	[SerializeField] private GameObject _stageFailedPop;
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
		GameStatus = Phase.Select;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GameClear()
	{
		//ゲームクリアしたときの処理
		_stageClearPop.SetActive(true);
	}

	void GameFail()
	{
		//ゲームに失敗した時の処理
		_stageFailedPop.SetActive(true);
	}

	void Check()
	{
		//Animalが当たってクリアかどうか判定
	}
	
}
