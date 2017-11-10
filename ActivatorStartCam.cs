using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorStartCam : MonoBehaviour
{
	public GameObject objectToActivate;

	private void Start()
	{
		StartCoroutine(ActivationRoutine());
	}

	private IEnumerator ActivationRoutine()
	{        
		//Wait for 24 seconds
		yield return new WaitForSeconds(24);

		//Turn My game object that is set to false(off) to True(on).
		objectToActivate.SetActive(true);

		//Turns the game object off after set seconds (10) have possed by
		yield return new WaitForSeconds(12);

		//Game object will be set to 'off'
		objectToActivate.SetActive(false);
	}
}
