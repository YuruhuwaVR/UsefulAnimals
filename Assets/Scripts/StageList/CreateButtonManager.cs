using System;
using UnityEngine;
using UnityEngine.UI;

public class CreateButtonManager : MonoBehaviour, ButtonManager{

	[SerializeField] Button createButton;
	[SerializeField] Transform privateView;
	[SerializeField] Transform publicView;

	private GameObject cellPrefab;
	const string PRIVATESTAGECELL = "StageCell/PrivateStageCell";

	public void Setup(){
		createButton.onClick.AddListener (() => {
			cellPrefab = Resources.Load<GameObject>(PRIVATESTAGECELL);
			GameObject cell = Instantiate(cellPrefab, privateView);
			PrivateCellManager cellManager = cell.GetComponent<PrivateCellManager>();
			cellManager.Setup(DateTime.Now.ToString("s"), publicView);
		});
	}
}
