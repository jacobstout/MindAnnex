 #pragma strict
  var time : float = 0;
 function Start() {
     time = 40;
 }
  
 function Update () {
     if(time > 0){
        time-=Time.deltaTime;
     }else{
        Application.LoadLevel("mcp_day");
     }
 }
 