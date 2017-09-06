using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UniRx;

public class EditButtonManager : MonoBehaviour{

	[SerializeField] Button editButton;

	const string STAGEEDITOR = "StageEditor";

	public void Setup(CSVManager csvManager){
		editButton.onClick.AddListener (() => {
			SceneManager.LoadSceneAsync(STAGEEDITOR).AsObservable().Subscribe(_ =>{
				var stageEditorManager = FindObjectOfType<StageEditorManager>();
				stageEditorManager.Setup(csvManager);
			});
		});
	}
}
