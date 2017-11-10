using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// should create a Typewriter form

public class TextTyper : MonoBehaviour 
{

	Text txt;
	string story;

	void Awake () 
	{
		txt = GetComponent<Text> ();
		story = txt.text;
		txt.text = "";

		// TODO: add optional delay when to start
		StartCoroutine ("PlayText");
	}

	IEnumerator PlayText()
	{
		foreach (char c in story) 
		{
			txt.text += c;
			yield return new WaitForSeconds (0.06f);
		}
	}

}