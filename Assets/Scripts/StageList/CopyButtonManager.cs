using System;
using UnityEngine;
using UnityEngine.UI;

public class CopyButtonManager : MonoBehaviour {

	[SerializeField] Button copyButton;

	private GameObject cellPrefab;
	const string PRIVATESTAGECELL = "StageCell/PrivateStageCell";

	public void Setup(Transform publicView, Transform privateView){
		copyButton.onClick.AddListener (() => {
			cellPrefab = Resources.Load<GameObject>(PRIVATESTAGECELL);
			GameObject cell = Instantiate(cellPrefab, privateView);
			PrivateCellManager cellManager = cell.GetComponent<PrivateCellManager>();
			cellManager.Setup(DateTime.Now.ToString("s"), publicView, privateView);
		});
	}
}
