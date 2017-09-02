using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockArrangeManager : MonoBehaviour {

	private static int[,] squares = new int[10, 10];

	public int[, ] Squares{
		get{ return squares;}
	}

	public void Arrange(int row, int col, int value){
		squares [row, col] = value;
	}
}
