using UnityEngine;

public class PrivateCellManager : MonoBehaviour {

	[SerializeField] EditButtonManager editButtonManager;
	[SerializeField] PublishButtonManager publishButtonManager;
	[SerializeField] DeleteButtonManager deleteButtonManager;

	private string stageId;

	private Transform publicView;

	public void Setup(string id, Transform publicView){
		stageId = id;
		this.publicView = publicView;
		editButtonManager.Setup ();
		publishButtonManager.Setup ();
		deleteButtonManager.Setup ();
	}

	public string StageId{ get{ return stageId; }}
	public Transform PublicView{get { return publicView;}}

}
