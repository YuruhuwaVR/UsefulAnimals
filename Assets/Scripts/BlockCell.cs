using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;


public class BlockCell : MonoBehaviour {

	[SerializeField] Image blockCellImage;
	[SerializeField] Button blockCellButton;
	[SerializeField] Rigidbody2D rb;
	private Vector3 position;
	private Quaternion rotation;
	private bool isBlock;
	public bool IsBlock {get{return isBlock;}}

	enum BlockState{
		Clear = 0,
		Square = 1,
		Circle = 2,
		Director = 3
	}

	private BlockState state = BlockState.Clear;
	 
	void Start(){
		blockCellButton.onClick.AddListener (() => {
			state = (BlockState)Enum.ToObject(typeof(BlockState), BlockChoiceManager.ChooseBlock);
			ChangeBlock(state);
		});
	}


	void ChangeBlock(BlockState state){
		switch (state) {
		case BlockState.Clear:
			blockCellImage.sprite = AssetDatabase.GetBuiltinExtraResource<Sprite> ("UI/Skin/UISprite.psd");
			blockCellImage.color = Color.clear;
			Destroy (this.GetComponent<Collider2D> ());
			isBlock = false;
			break;

		case BlockState.Square:
			blockCellImage.sprite = AssetDatabase.GetBuiltinExtraResource<Sprite> ("UI/Skin/UISprite.psd");
			blockCellImage.color = Color.red;
			Destroy (this.GetComponent<Collider2D> ());
			BoxCollider2D bc = this.gameObject.AddComponent (typeof(BoxCollider2D)) as BoxCollider2D;
			bc.size = new Vector2(50f, 50f);
			isBlock = true;
			break;

		case BlockState.Circle:
			blockCellImage.sprite = AssetDatabase.GetBuiltinExtraResource<Sprite> ("UI/Skin/Knob.psd");
			blockCellImage.color = Color.blue;
			Destroy (this.GetComponent<Collider2D>());
			CircleCollider2D cc = this.gameObject.AddComponent(typeof(CircleCollider2D)) as CircleCollider2D;
			cc.radius = 25f;
			isBlock = true;
			break;

		case BlockState.Director:
			blockCellImage.sprite = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/Background.psd");
			blockCellImage.color = Color.green;
			Destroy (this.GetComponent<Collider2D> ());
			BoxCollider2D dc = this.gameObject.AddComponent (typeof(BoxCollider2D)) as BoxCollider2D;
			dc.size = new Vector2(50f, 50f);
			isBlock = true;
			break;
		}
	}

	public void ApplyGravity(){
		position = this.gameObject.transform.position;
		rotation = this.gameObject.transform.rotation;
		rb.bodyType = RigidbodyType2D.Dynamic;
		rb.gravityScale = 0.5f;
	}

	public void Reset(){
		rb.bodyType = RigidbodyType2D.Static;
		this.gameObject.transform.position = position;
		this.gameObject.transform.rotation = rotation;	
	}
}
