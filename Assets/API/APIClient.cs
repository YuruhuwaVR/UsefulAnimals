using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIClient: MonoBehaviour {
	string rootUrl = "http://localhost:1323/";
	void ResponseFrom(HTTPRequest request)
	{
		string url = rootUrl + request.RelativeUrl;
		WWW www = new WWW(url);
		StartCoroutine("ConnectionEnd", www);
	}

	private IEnumerator WaitingForRequest(WWW www)
	{
		yield return www;
		ConnectionEnd(www);
	}

	private void ConnectionEnd(WWW www)
	{
		// hogehoge
	}
}
