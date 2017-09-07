using UnityEngine;

public class StageEditorManager : MonoBehaviour {

	[SerializeField] SaveButtonManager saveButtonManager;
	[SerializeField] PreviewButtonManager previewButtonManager;
	[SerializeField] BackButtonManager backButtonManager;
	[SerializeField] GameObject blockArrangePanel;
	private CSVManager csvManager;
	private int[] csvData;
	private BlockCell[] blockCells;


	private string stageId;

	void Awake(){
		previewButtonManager.Setup ();
		backButtonManager.Setup ();


	}

	public void Setup(CSVManager csvManager){
		this.stageId = csvManager.StageId;

		Load (csvManager);

		saveButtonManager.Setup (csvManager);
	}

	private void Load(CSVManager csvManager){
		csvData = csvManager.CsvRead();
		blockCells = blockArrangePanel.GetComponentsInChildren<BlockCell>();

		for(int i=0; i < csvData.Length; i++){
			blockCells[i].Load(csvData[i]);
		}
	}
		
}
