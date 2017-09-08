using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PublishButtonManager : MonoBehaviour{

	[SerializeField] Button publishButton;
	[SerializeField] PrivateCellManager privateCellManager;

	private Transform publicView;
	const string PUBLICSTAGECELL = "StageCell/PublicStageCell";


	public void Setup () {
		publicView = privateCellManager.PublicView;

		publishButton.onClick.AddListener (() => {


			CreateCell(privateCellManager.StageId);

			string txtPath = Application.dataPath + "/Resources/txt/private/" + this.GetComponentInParent<PrivateCellManager>().StageId + ".txt";
		
			File.Delete(txtPath);

			Destroy(transform.parent.gameObject);
		});
	}

	private void CreateCell(string stageId){
		GameObject cellPrefab = Resources.Load<GameObject>(PUBLICSTAGECELL);
		GameObject cell = Instantiate(cellPrefab, publicView);
		PublicCellManager cellManager = cell.GetComponent<PublicCellManager>();
		cellManager.Setup(stageId);
	}
}
