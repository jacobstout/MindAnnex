using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections;

public class TrainForward1 : MonoBehaviour {
	public float speed;

	void Update() {
		transform.Translate(Vector3.right * Time.deltaTime * speed);
	}
}