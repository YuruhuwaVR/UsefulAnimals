using UnityEngine;
using UnityEngine.UI;

public class SaveButtonManager : MonoBehaviour, ButtonManager {

	[SerializeField] Button saveButton;
	[SerializeField] BlockArrangeManager blockArrangeManager;
	private int[, ] csvData;
	private CSVManager csvManager;

	public void Setup () {
		saveButton.onClick.AddListener (() => {
			csvData = blockArrangeManager.Squares;

			csvManager = new CSVManager ();

			csvManager.CsvWrite(csvData);
		});
	}
}
