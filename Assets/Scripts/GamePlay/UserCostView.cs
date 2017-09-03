using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class UserCostView : MonoBehaviour
{

	[SerializeField] private Text _userCost;
	private int _userMaxCost;
	private int _userLeftCost;
	
	// Use this for initialization
	void Start ()
	{
		//あとでuserとひもづけ
		_userMaxCost = 10;
	}
	
	// Update is called once per frame
	void Update ()
	{
		_userLeftCost = PlayManager.instance._currentCost;
		_userCost.text = _userLeftCost.ToString() + " / " + _userMaxCost.ToString();
	}
}
