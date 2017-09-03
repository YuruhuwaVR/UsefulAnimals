using UnityEngine;
using UnityEngine.UI;

public class PrivateButtonManager : MonoBehaviour, ButtonManager {

	[SerializeField] GameObject publicView;
	[SerializeField] GameObject privateView;
	[SerializeField] Button privateButton;

	public void Setup(){
		privateButton.onClick.AddListener (() => {
			publicView.SetActive(false);
			privateView.SetActive(true);	
		});
	}
}
