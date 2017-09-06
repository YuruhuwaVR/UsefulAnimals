using UnityEngine;
using UnityEngine.UI;

public class DeleteButtonManager : MonoBehaviour{

	[SerializeField] Button deleteButton;

	public void Setup(){
		deleteButton.onClick.AddListener (() => {
			Destroy(transform.parent.gameObject);	
		});
	}
}
