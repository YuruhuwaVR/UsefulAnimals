using UnityEngine;

public class TextManager : MonoBehaviour {

	[SerializeField] PublicViewManager publicViewManager;
	[SerializeField] PrivateViewManager privateViewManager;

	public void Setup(){
		publicViewManager.Load ();
		privateViewManager.Load ();
	}
}
