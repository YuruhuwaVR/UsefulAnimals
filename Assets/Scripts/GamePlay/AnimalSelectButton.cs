using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class AnimalSelectButton : MonoBehaviour
{
	[SerializeField] private GameObject _animalPrefab;
	[SerializeField] private Text _animalLabel;
	[SerializeField] private Text _costLabel;
	private Button _button;
	private Text _text;
	private Animal _animal;

	// Use this for initialization
	void Start ()
	{
		_button = GetComponent<Button>();
		_animal = _animalPrefab.GetComponent<Animal>();
		_costLabel.text = _animal.Cost.ToString();
		_animalLabel.text =  _animal.Name;
	}
	
	// Update is called once per frame
	void Update ()
	{	
		_button.interactable = true;
		if (PlayManager.instance._currentCost <  _animal.Cost || PlayManager.instance.GameStatus != PlayManager.Phase.Select || PlayManager.instance._currentAnimal != null)
		{
			_button.interactable = false;
		}	
	}

	public void SelectedButton()
	{
		PlayManager.instance._currentAnimal = _animalPrefab;
		PlayManager.instance._currentCost -= _animal.Cost;
	}
}
