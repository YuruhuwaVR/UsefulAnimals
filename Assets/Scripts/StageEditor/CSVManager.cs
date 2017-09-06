using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;


public class CSVManager{


	private const int SIZE = 10;
	private int[] csvData;
	private string stageId;
	private string path;

	public string StageId{get{ return stageId;} set{ stageId = value;}}

	public CSVManager (string stageId){
		this.StageId = stageId;
		path = Application.dataPath + "/Resources/csv/" + stageId + ".csv";
	}

	public int[] CsvRead () {

		string[] csvData_str = {};

		using (FileStream fs = new FileStream (path, FileMode.Open)) {
			using (StreamReader sr = new StreamReader (fs)) {
				while (sr.Peek () > -1) {
					string line = sr.ReadLine ();
					string[] entries = line.Split (new []{ "," }, StringSplitOptions.None);
					csvData_str = csvData_str.Concat (entries).ToArray();
				}
					
				csvData = Array.ConvertAll (
					csvData_str,
					delegate(string value) {
						return int.Parse(value);
					}
				);
	
			}
		}

		return csvData;
	}

	public void CsvWrite(int[, ] csvData){
		string[] lines = new string[SIZE];

		for (int i = 0; i < SIZE; i++) {
			string line = "";

			for (int j = 0; j < SIZE; j++) {
				line += csvData[i, j].ToString();

				if (j < SIZE - 1) {
					line += ',';
				}
			}

			lines[i] = line;
		}

		using (StreamWriter sw = new StreamWriter (path)) {
			foreach(string line in lines){
				sw.WriteLine(line);
			}	
		}
	}
}
