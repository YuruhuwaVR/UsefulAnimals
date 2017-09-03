using UnityEngine;
using UnityEngine.UI;

public class PublicButtonManager : MonoBehaviour, ButtonManager {

	[SerializeField] GameObject publicView;
	[SerializeField] GameObject privateView;
	[SerializeField] Button publicButton;

	public void Setup(){
		publicButton.onClick.AddListener (() => {
			privateView.SetActive(false);
			publicView.SetActive(true);	
		});
	}
}
