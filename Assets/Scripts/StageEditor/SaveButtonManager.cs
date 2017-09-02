using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveButtonManager : MonoBehaviour {

	[SerializeField] Button saveButton;
	[SerializeField] BlockArrangeManager blockArrangeManager;
	private int[, ] csvData;
	private CSVManager csvManager;

	void Start () {
		saveButton.onClick.AddListener (() => {
			csvData = blockArrangeManager.Squares;

			csvManager = new CSVManager ();

			csvManager.CsvWrite(csvData);
		});
	}
}
