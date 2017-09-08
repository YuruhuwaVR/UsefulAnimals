using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DeleteButtonManager : MonoBehaviour{

	[SerializeField] Button deleteButton;

	public void Setup(string txtPath, string csvPath){
		deleteButton.onClick.AddListener (() => {
			File.Delete(txtPath);
			File.Delete(csvPath);

			Destroy(transform.parent.gameObject);	
		});
	}
}
