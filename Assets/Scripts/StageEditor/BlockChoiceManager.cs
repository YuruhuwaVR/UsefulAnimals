using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockChoiceManager: MonoBehaviour{
	private static int chosenBlockNum = 0;

	public static int ChooseBlock {
		get{ return chosenBlockNum;}
		set{ chosenBlockNum = value;}
	}

	void Start(){
		IBlockChoiceCell[] blockChoiceCells = GetComponentsInChildren<IBlockChoiceCell>();

		foreach(IBlockChoiceCell blockChoiceCell in blockChoiceCells){
			blockChoiceCell.Setup(blockChoiceCells);
		}
	}
}
