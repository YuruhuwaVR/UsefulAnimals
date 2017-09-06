using UnityEngine;
using UnityEngine.UI;

public class SaveButtonManager : MonoBehaviour{

	[SerializeField] Button saveButton;
	[SerializeField] BlockArrangeManager blockArrangeManager;
	private int[, ] csvData;

	public void Setup (CSVManager csvManager) {
		saveButton.onClick.AddListener (() => {
			csvData = blockArrangeManager.Squares;

			csvManager.CsvWrite(csvData);
		});
	}
}
