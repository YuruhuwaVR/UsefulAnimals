using UnityEngine;
using UnityEngine.UI;

public class PublishButtonManager : MonoBehaviour{

	[SerializeField] Button publishButton;
	[SerializeField] PrivateCellManager privateCellManager;

	
	private GameObject cellPrefab;
	private Transform publicView;
	const string PUBLICSTAGECELL = "StageCell/PublicStageCell";


	public void Setup () {
		publicView = privateCellManager.PublicView;

		publishButton.onClick.AddListener (() => {

			cellPrefab = Resources.Load<GameObject>(PUBLICSTAGECELL);


			GameObject cell = Instantiate(cellPrefab, publicView);
			PublicCellManager cellManager = cell.GetComponent<PublicCellManager>();
			cellManager.Setup(privateCellManager.StageId);


			Destroy(transform.parent.gameObject);	
		});
	}
}
