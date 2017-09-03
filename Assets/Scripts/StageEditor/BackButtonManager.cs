using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButtonManager : MonoBehaviour, ButtonManager {

	[SerializeField] Button backButton;

	const string STAGELIST = "StageList";

	public void Setup(){
		backButton.onClick.AddListener (() => {
			SceneManager.LoadSceneAsync(STAGELIST);
		});
	}
}
