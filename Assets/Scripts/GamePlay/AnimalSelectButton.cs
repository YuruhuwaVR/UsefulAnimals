using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class AnimalSelectButton : MonoBehaviour
{
	[SerializeField] private GameObject _animalPrefab;
	[SerializeField] private Text _animalLabel;
	[SerializeField] private Text _costLabel;
	[SerializeField] private string _animalName;
	[SerializeField] private int _cost;

	private Button _button;
	private Text _text;

	// Use this for initialization
	void Start ()
	{
		_button = GetComponent<Button>();
		_costLabel.text = _cost.ToString();
		_animalLabel.text = _animalName;
	}
	
	// Update is called once per frame
	void Update ()
	{	
		_button.interactable = true;
		if (PlayManager.instance._currentCost < _cost)
		{
			_button.interactable = false;
		}	
	}

	public void SelectedButton()
	{
		PlayManager.instance._currentAnimal = _animalPrefab;
		PlayManager.instance._currentCost -= _cost;
	}
}
