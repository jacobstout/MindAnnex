#pragma strict

function OnTriggerEnter(other : Collider){
//If a gameObject with the tag "Player" enters this trigger, load a scene.
if(other.gameObject.tag == "Player"){
Application.LoadLevel("jump_scene");
}
}
 
