using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : Animal {

	protected override void SpecialAttack()
	{
		//必殺技
		gameObject.transform.localScale *= 3;
		Weight *= 3;
	}
}
