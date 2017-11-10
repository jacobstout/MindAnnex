using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggeroofSound : MonoBehaviour {
	public bool enter;
	public AudioClip alarm;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		enter = false;
		source = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

		if (enter == true)
			source.PlayOneShot (alarm);
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			enter = true;

		}
		Debug.Log ("Entered");
	}

	//Deactivate the Main function when player is go away from alarm spot
	void OnTriggerExit (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			enter = false;
		}
		Debug.Log ("Exited");
	}
}
