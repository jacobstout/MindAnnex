using UnityEngine;
using System.Collections;

public class loadFirstCut: MonoBehaviour {

	void Update(){
		if(Input.GetKeyDown(KeyCode.Z)){
			Application.LoadLevel("box_cutscene");
		}
	}
}