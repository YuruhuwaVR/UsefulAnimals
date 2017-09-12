using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : Animal {

	protected override void SpecialAttack()
	{
		//必殺技
		var obstacles = GameObject.FindGameObjectsWithTag ("Obstacle");
		foreach (var obj in obstacles)
		{
			if (obj.GetComponent<Thicket>() != null)
			{
				obj.GetComponent<Thicket>().ChangeLayer();
			}
		}
	}
}
