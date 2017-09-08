using UnityEngine;

public class PublicViewManager : MonoBehaviour {

	const string PUBLICPATH = "txt/public";
	const string PUBLICSTAGECELL = "StageCell/PublicStageCell";
	char[] charsToTrim = { '\0', '\r', '\n'};


	public void Load(){
		Object[] texts =  Resources.LoadAll (PUBLICPATH);

		if (texts == null) {
			return;
		}

		TextAsset[] publicCells = new TextAsset[texts.Length];
		texts.CopyTo (publicCells, 0);


		foreach (TextAsset publicCell in publicCells) {
			string text = publicCell.text.TrimEnd(charsToTrim);
			CreateCell (text);
		}
	}

	private void CreateCell(string stageId){
		GameObject cellPrefab = Resources.Load<GameObject>(PUBLICSTAGECELL);
		GameObject cell = Instantiate(cellPrefab, this.transform);
		PublicCellManager cellManager = cell.GetComponent<PublicCellManager>();
		cellManager.Setup(stageId);
	}
}
