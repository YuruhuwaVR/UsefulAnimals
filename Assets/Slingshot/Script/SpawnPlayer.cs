using System.Collections;
using UnityEngine;

namespace AngryChicken2D
{
	public class SpawnPlayer : MonoBehaviour
	{
		bool canSpawn = true;
		SlingShot slingShot;
		GameObject catchObject;

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
			
			print(PlayManager.instance.GameStatus);
			
			//動物選択
			if (canSpawn)
			{
				GameObject selectedAnimal = PlayManager.instance._currentAnimal;
				if(selectedAnimal != null)
				{
					GameObject animal = Instantiate(selectedAnimal) as GameObject;
					animal.transform.position = gameObject.transform.position;
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
				canSpawn = true;
				catchObject = null;
				PlayManager.instance.GameStatus = PlayManager.Phase.Select;
			}
		}

		IEnumerator Shooting(GameObject obj)
		{
			
			DestroyObject(obj, 5);
			yield return new WaitForSeconds(respawnTime);
			PlayManager.instance._currentAnimal = null;
			canSpawn = true;
			PlayManager.instance.GameStatus = PlayManager.Phase.Select;
		}
	}
}