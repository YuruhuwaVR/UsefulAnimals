using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ClearChoiceCell : MonoBehaviour, IBlockChoiceCell {
	[SerializeField] Button choiceButton;
	[SerializeField] Image choiceCellImage;
	private const int BLOCKNUM = 0;
	private Color blockColor = Color.white;

	public void Setup(IBlockChoiceCell[] blockChoiceCells){
		choiceButton.onClick.AddListener(() => {
			BlockChoiceManager.ChooseBlock = BLOCKNUM;
			choiceCellImage.color = blockColor;

			foreach(IBlockChoiceCell blockChoiceCell in blockChoiceCells){
				if(blockChoiceCell == this){
					continue;
				}

				blockChoiceCell.Disable();
			}
		});
	}

	public void Disable(){
		choiceCellImage.color = Color.clear;
	}
}
