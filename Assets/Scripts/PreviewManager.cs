using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PreviewManager : MonoBehaviour {
	[SerializeField] GameObject blockArrangePanel;
	[SerializeField] Button previewButton;
	[SerializeField] Button resetButton;
	private List<BlockCell> blockCells;
	private List<BlockCell> dynamicCells;
	private List<BlockCell> staticCells;

	void Start(){
		blockCells = new List<BlockCell> ();
		dynamicCells = new List<BlockCell> ();
		staticCells = new List<BlockCell> ();

		previewButton.onClick.AddListener (() => {
			Initialize();
			GetBlockCells();
			Preview();

		});

		resetButton.onClick.AddListener (() => {
			Reset();
		});
	}

	void Initialize(){
		blockCells.Clear ();
		dynamicCells.Clear ();
		staticCells.Clear ();
	}

	void GetBlockCells(){
		blockCells.AddRange(blockArrangePanel.GetComponentsInChildren<BlockCell> ());
		foreach (BlockCell cell in blockCells) {
			if (cell.IsBlock) {
				dynamicCells.Add (cell);
			}
			else {
				staticCells.Add (cell);
			}
		}
	}
	void Preview(){
		foreach(BlockCell cell in staticCells){
			cell.gameObject.SetActive (false);
		}
			
		foreach (BlockCell cell in dynamicCells) {
			cell.ApplyGravity ();
		}
	}

	void Reset(){
		foreach (BlockCell cell in dynamicCells) {
			cell.Reset ();
		}

		foreach (BlockCell cell in staticCells) {
			cell.gameObject.SetActive (true);
		}
	}
}
