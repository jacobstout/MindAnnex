 #pragma strict
  var time : float = 0;
 function Start() {
     time = 34;
 }
  
 function Update () {
     if(time > 0){
        time-=Time.deltaTime;
     }else{
        Application.LoadLevel("bedroom_scene");
     }
 }
 