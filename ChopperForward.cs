using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections;

public class ChopperForward : MonoBehaviour {
	public float speed;

	void Update() {
		transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}
}
// Vector3.forward will push the helicopter in the opening scene forward, please use other scripts for other movements - Jacob.