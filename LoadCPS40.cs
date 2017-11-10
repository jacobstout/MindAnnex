using UnityEngine;
using System.Collections;

public class LoadCPS40 : MonoBehaviour {


	public void  ModeSelect(){
		StartCoroutine(LoadAfterDelay("JumpSceneAYE"));
	}

	IEnumerator LoadAfterDelay(string levelName){
		yield return new WaitForSeconds(15); // wait 15 seconds, let Character search the box.
		Application.LoadLevel(3);

	}
}