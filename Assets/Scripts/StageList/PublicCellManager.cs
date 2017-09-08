using System.IO;
using UnityEngine;

public class PublicCellManager : MonoBehaviour {

	[SerializeField] DeleteButtonManager deleteButtonManager;

	private string stageId;
	private string txtPath;
	
	public void Setup (string id) {
		stageId = id;
		txtPath = Application.dataPath + "/Resources/txt/public/" + id + ".txt";

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
}
