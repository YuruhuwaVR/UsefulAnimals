using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DeleteButtonManager : MonoBehaviour{

	[SerializeField] Button deleteButton;

	public void Setup(string txtPath){
		deleteButton.onClick.AddListener (() => {
			File.Delete(txtPath);

			Destroy(transform.parent.gameObject);	
		});
	}
}
