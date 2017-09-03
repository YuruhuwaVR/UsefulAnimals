using System.Collections;
using UnityEngine;

namespace AngryChicken2D
{
	public class SpawnPlayer : MonoBehaviour
	{
		private bool canSpawn = true;
		private SlingShot slingShot;
		private GameObject catchObject;
		private GameObject instantiateAnimal;

		[Range(3, 30)]
		public int
			respawnTime = 5;

		void Start()
		{
			slingShot = GetComponent<SlingShot>();
//			if (playerPrefab == null)
//				enabled = false;
		}
	
		void Update()
		{
			
			//動物選択
			if (canSpawn )
			{
				GameObject selectedAnimal = PlayManager.instance._currentAnimal;
				if(selectedAnimal != null)
				{
					instantiateAnimal = Instantiate(selectedAnimal) as GameObject;
					instantiateAnimal.transform.position = gameObject.transform.position;
					canSpawn = false;
				}

			} else {
				if (catchObject == null)
				{
					catchObject = slingShot.catchObject;
				}

				if (catchObject != null && Vector2.Distance(catchObject.transform.position, transform.position) > slingShot.maxPower * 1.3f)
				{
					//StartCoroutine(Shooting(catchObject));
					//catchObject = null;
//					PlayManager.instance.GameStatus = PlayManager.Phase.Flying;
				}
			}

			if (PlayManager.instance.GameStatus == PlayManager.Phase.Ready)
			{
				PlayManager.instance._currentAnimal = null;
				canSpawn = true;
				catchObject = null;
				PlayManager.instance.GameStatus = PlayManager.Phase.Select;
			}
		}

		// change animalボタン用
		public void ChangeAnimal()
		{
			GameObject selectedAnimal = PlayManager.instance._currentAnimal;
			PlayManager.instance._currentCost += selectedAnimal.GetComponent<Animal>().Cost;
			PlayManager.instance._currentAnimal = null;
			Destroy(instantiateAnimal);
			canSpawn = true;
		}
	}
}