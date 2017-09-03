using System;
using UnityEngine;
using UnityEngine.UI;

public class CreateButtonManager : MonoBehaviour, ButtonManager{

	[SerializeField] Button createButton;
	[SerializeField] Transform privateView;

	private GameObject cellPrefab;
	private string PRIVATESTAGECELL = "StageCell/PrivateStageCell";

	public void Setup(){
		createButton.onClick.AddListener (() => {
			cellPrefab = Resources.Load<GameObject>(PRIVATESTAGECELL);
			GameObject cell = Instantiate(cellPrefab, privateView);
			CellInfoManager cellInfoManager = cell.GetComponent<CellInfoManager>();
			cellInfoManager.StageId = DateTime.Now.ToString("s");

		});
	}
}
