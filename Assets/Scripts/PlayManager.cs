using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;


public class PlayManager : MonoBehaviour
{

	//private Stage _stage;
	private Animal _currentAnimal;

	public enum Phase
	{
		Start,
		Select,
		Ready,
		Flying
	}

	private int _currentCost;
	private bool _specialAttack; //これAnimalクラス？？
	
	

	// Use this for initialization
	void Start () {
		
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
