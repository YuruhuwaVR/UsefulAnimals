using UnityEngine;

public class PrivateViewManager : MonoBehaviour {

	const string PRIVATEPATH = "txt/private";
	char[] charsToTrim = { '\0', '\r', '\n'};

	[SerializeField] CreateButtonManager createButtonManager;

	public void Load(){
		Object[] texts =  Resources.LoadAll (PRIVATEPATH);

		if (texts == null) {
			return;
		}

		TextAsset[] privateCells = new TextAsset[texts.Length];
		texts.CopyTo (privateCells, 0);


		foreach (TextAsset privateCell in privateCells) {
			string text = privateCell.text.TrimEnd(charsToTrim);
			createButtonManager.CreateCell (text);
		}
	}
}
