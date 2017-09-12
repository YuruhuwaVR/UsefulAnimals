using UnityEngine;

public class Rat : Animal
{
	protected override void SpecialAttack()
	{
		var obstacles = GameObject.FindGameObjectsWithTag ("Obstacle");
		foreach (var obj in obstacles)
		{
			if (obj.GetComponent<Tree>() != null)
			{
				obj.GetComponent<Tree>().ChangeLayer();
			}
		}
	}
}
