using System;
using UnityEngine;
using UnityEngine.UI;

public class CreateButtonManager : MonoBehaviour{

	[SerializeField] Button createButton;
	[SerializeField] Transform privateView;
	[SerializeField] Transform publicView;

	private GameObject cellPrefab;
	const string PRIVATESTAGECELL = "StageCell/PrivateStageCell";

	public void Setup(){
		createButton.onClick.AddListener (() => {
			string stageId = DateTime.Now.ToString("s");
			CreateCell(stageId);
		});
	}

	public void CreateCell(string stageId){
		cellPrefab = Resources.Load<GameObject>(PRIVATESTAGECELL);
		GameObject cell = Instantiate(cellPrefab, privateView);
		PrivateCellManager cellManager = cell.GetComponent<PrivateCellManager>();
		cellManager.Setup(stageId, publicView, privateView);
	}
}
