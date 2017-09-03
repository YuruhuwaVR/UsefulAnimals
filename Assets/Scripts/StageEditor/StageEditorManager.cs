using UnityEngine;


public class StageEditorManager : MonoBehaviour {

	[SerializeField] LoadButtonManager loadButtonManager;
	[SerializeField] SaveButtonManager saveButtonManager;
	[SerializeField] PreviewButtonManager previewButtonManager;
	[SerializeField] BackButtonManager backButtonManager;


	void Awake(){
		loadButtonManager.Setup();
		saveButtonManager.Setup ();
		previewButtonManager.Setup ();
		backButtonManager.Setup ();
	}
}
