using System.IO;
using UnityEngine;

public class PrivateCellManager : MonoBehaviour {

	[SerializeField] EditButtonManager editButtonManager;
	[SerializeField] CopyButtonManager copyButtonManager;
	[SerializeField] PublishButtonManager publishButtonManager;
	[SerializeField] DeleteButtonManager deleteButtonManager;

	private string stageId;
	private string txtPath;
	private Transform publicView;

	const int PANELSIZE = 10;

	public string StageId{ get{ return stageId; }}
	public Transform PublicView{get { return publicView;}}

	public void Setup(string id, Transform publicView, Transform privateView){
		stageId = id;
		txtPath = Application.dataPath + "/Resources/txt/private/" + id + ".txt";
		this.publicView = publicView;

		CSVManager csvManager = InitializeCSVData (id);

		editButtonManager.Setup (csvManager);
		copyButtonManager.Setup (publicView, privateView);
		publishButtonManager.Setup ();
		deleteButtonManager.Setup (txtPath);

		Save ();
	}

	private void Save(){
		if (File.Exists (txtPath)) {
			return;
		}
			

		using (StreamWriter sw = new StreamWriter (txtPath)) {
			sw.WriteLine(stageId);			
		}
	}

	private CSVManager InitializeCSVData(string stageId){
		CSVManager m_csvManager = new CSVManager (stageId);

		if (!(File.Exists (txtPath))) {
			m_csvManager.CsvWrite (new int[PANELSIZE, PANELSIZE]);
		}
		return m_csvManager;
	}





}
