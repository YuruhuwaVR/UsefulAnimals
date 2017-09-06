using UnityEngine;

public class PrivateCellManager : MonoBehaviour {

	[SerializeField] EditButtonManager editButtonManager;
	[SerializeField] CopyButtonManager copyButtonManager;
	[SerializeField] PublishButtonManager publishButtonManager;
	[SerializeField] DeleteButtonManager deleteButtonManager;

	private string stageId;
	private Transform publicView;
	private CSVManager csvManager;

	const int PANELSIZE = 10;

	public string StageId{ get{ return stageId; }}
	public Transform PublicView{get { return publicView;}}

	public void Setup(string id, Transform publicView, Transform privateView){
		stageId = id;
		this.publicView = publicView;

		csvManager = InitializeCSVData (id);

		editButtonManager.Setup (csvManager);
		copyButtonManager.Setup (publicView, privateView);
		publishButtonManager.Setup ();
		deleteButtonManager.Setup ();
	}

	private CSVManager InitializeCSVData(string stageId){
		CSVManager m_csvManager = new CSVManager (stageId);
		m_csvManager.CsvWrite (new int[PANELSIZE, PANELSIZE]);
		return m_csvManager;
	}



}
