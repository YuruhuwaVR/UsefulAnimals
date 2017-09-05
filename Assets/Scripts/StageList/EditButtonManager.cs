using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EditButtonManager : MonoBehaviour, ButtonManager {

	[SerializeField] Button editButton;

	const string STAGEEDITOR = "StageEditor";

	public void Setup(){
		editButton.onClick.AddListener (() => {
			SceneManager.LoadSceneAsync(STAGEEDITOR);
		});
	}
}
