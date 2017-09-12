public class Iron : ClashBlock {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	//とらの必殺技によるダメージ
	public void GetDamage(float power)
	{
		Hp -= (int)power;
	}

}
