using UnityEngine;

public class PublicCellManager : MonoBehaviour {

	[SerializeField] DeleteButtonManager deleteButtonManager;

	private string stageId;

	
	public void Setup (string id) {
		stageId = id;
		deleteButtonManager.Setup ();
	}
}
