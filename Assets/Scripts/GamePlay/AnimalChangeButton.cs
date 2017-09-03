﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalChangeButton : MonoBehaviour {
	
	private Button _button;

	// Use this for initialization
	void Start () {
		_button = GetComponent<Button>();
		_button.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (PlayManager.instance._currentAnimal != null && PlayManager.instance.GameStatus == PlayManager.Phase.Select)
		{
			_button.interactable = true;
		}
	}

}
