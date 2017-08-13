using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockCell : MonoBehaviour {

	[SerializeField] Image blockCellImage;
	[SerializeField] Button blockCellButton;

	enum BlockState{
		Clear = 0,
		Square = 1,
		Circle = 2,
		Director = 3
	}

	private BlockState state = BlockState.Clear;
	 
	void Start(){
		blockCellButton.onClick.AddListener (() => {
			state = (BlockState)Enum.ToObject(typeof(BlockState), BlockChoiceManager.ChooseBlock);
		});
	}

	void Update(){
		switch (state) {
		case BlockState.Clear:
			//blockCellImage.sprite = null;
			blockCellImage.color = new Color(1.0f, 1.0f, 1.0f, 0.2f);
			break;

		case BlockState.Square:
			//blockCellImage.sprite = null;
			blockCellImage.color = Color.red;
			break;

		case BlockState.Circle:
			//blockCellImage.sprite = null;
			blockCellImage.color = Color.blue;
			break;
		    
		case BlockState.Director:
			//blockCellImage.sprite = null;
			blockCellImage.color = Color.green;
			break;
		}
	}
}
