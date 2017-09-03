using UnityEngine;

public class StageListManager : MonoBehaviour {

	[SerializeField] PublicButtonManager publicButtonManager;
	[SerializeField] PrivateButtonManager privateButtonManager;
	[SerializeField] CreateButtonManager createButtonManager;

	void Awake () {
		publicButtonManager.Setup ();
		privateButtonManager.Setup ();
		createButtonManager.Setup ();
	}
	

}
