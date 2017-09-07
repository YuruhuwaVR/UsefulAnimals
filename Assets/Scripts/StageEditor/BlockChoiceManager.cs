using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockChoiceManager: MonoBehaviour{
	private static int chosenBlockNum = -1;

	public static int ChooseBlock {
		get{ return chosenBlockNum;}
		set{ chosenBlockNum = value;}
	}

	void Start(){
		chosenBlockNum = -1;

		IBlockChoiceCell[] blockChoiceCells = GetComponentsInChildren<IBlockChoiceCell>();

		foreach(IBlockChoiceCell blockChoiceCell in blockChoiceCells){
			blockChoiceCell.Setup(blockChoiceCells);
		}
	}
}
