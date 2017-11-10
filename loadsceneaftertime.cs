using UnityEngine;
using System.Collections;

public class loadsceneaftertime : MonoBehaviour {


	public void  ModeSelect(){
		StartCoroutine(LoadAfterDelay("FallSceneAYE"));
	}

	IEnumerator LoadAfterDelay(string levelName){
		yield return new WaitForSeconds(10); // wait 22 seconds
		Application.LoadLevel(5);

	}
}