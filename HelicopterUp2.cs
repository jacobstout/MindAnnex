using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections;

public class HelicopterUp2 : MonoBehaviour {
	public float speed;

	void Update() {
		transform.Translate(Vector3.down * Time.deltaTime * speed);
	}
}