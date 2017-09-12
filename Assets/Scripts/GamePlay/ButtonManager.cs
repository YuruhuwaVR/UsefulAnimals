using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

	[SerializeField] private GameObject _retirePop;
	[SerializeField] private AudioClip _pushClip;
	private Button _button;
	private AudioSource _audioSource;
	
	// Use this for initialization
	void Start ()
	{
		_button = GetComponent<Button>();
		_audioSource = GetComponent<AudioSource>();
		_retirePop.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RetireButton()
	{
		_audioSource.PlayOneShot(_pushClip);
		_button.interactable = false;
		PlayManager.instance.GameStatus = PlayManager.Phase.Ready;
		_retirePop.SetActive(true);
	}

	public void RetireYes()
	{
		_audioSource.PlayOneShot(_pushClip);
		SceneManager.LoadScene("Select");
	}

	public void RetireNo()
	{
		_audioSource.PlayOneShot(_pushClip);
		_retirePop.SetActive(false);
		_button.interactable = true;
		PlayManager.instance.GameStatus = PlayManager.Phase.Select;
	}

	public void Retry()
	{
		_audioSource.PlayOneShot(_pushClip);
		SceneManager.LoadScene("Play");
	}

	public void Back()
	{
		_audioSource.PlayOneShot(_pushClip);
		SceneManager.LoadScene("Select");
	}
}
