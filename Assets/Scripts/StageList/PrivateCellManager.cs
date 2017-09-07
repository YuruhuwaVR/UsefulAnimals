﻿using System.IO;
using UnityEngine;

public class PrivateCellManager : MonoBehaviour {

	[SerializeField] EditButtonManager editButtonManager;
	[SerializeField] CopyButtonManager copyButtonManager;
	[SerializeField] PublishButtonManager publishButtonManager;
	[SerializeField] DeleteButtonManager deleteButtonManager;

	private string stageId;
	private string txtpath;
	private Transform publicView;

	const int PANELSIZE = 10;

	public string StageId{ get{ return stageId; }}
	public Transform PublicView{get { return publicView;}}

	public void Setup(string id, Transform publicView, Transform privateView){
		stageId = id;
		txtpath = Application.dataPath + "/Resources/txt/private/" + id + ".txt";
		this.publicView = publicView;

		CSVManager csvManager = InitializeCSVData (id);

		editButtonManager.Setup (csvManager);
		copyButtonManager.Setup (publicView, privateView);
		publishButtonManager.Setup ();
		deleteButtonManager.Setup ();

		Save ();
	}

	private void Save(){
		if (File.Exists (txtpath)) {
			return;
		}
			

		using (StreamWriter sw = new StreamWriter (txtpath)) {
			sw.WriteLine(stageId);			
		}
	}

	private CSVManager InitializeCSVData(string stageId){
		CSVManager m_csvManager = new CSVManager (stageId);

		if (!(File.Exists (txtpath))) {
			m_csvManager.CsvWrite (new int[PANELSIZE, PANELSIZE]);
		}
		return m_csvManager;
	}





}
