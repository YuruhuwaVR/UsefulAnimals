using UnityEngine;
using UnityEngine.UI;

public class LoadButtonManager : MonoBehaviour, ButtonManager {

	[SerializeField] Button loadButton;
	[SerializeField] GameObject blockArrangePanel;
	private CSVManager csvManager;
	private int[] csvData;
	private BlockCell[] blockCells;

	public void Setup () {
		loadButton.onClick.AddListener (() => {
			csvManager = new CSVManager();
			csvData = csvManager.CsvRead();
			blockCells = blockArrangePanel.GetComponentsInChildren<BlockCell>();

			for(int i=0; i < csvData.Length; i++){
				blockCells[i].Load(csvData[i]);
			}
		});
	}

}
