using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneContoller : MonoBehaviour
{
    
    public GameObject[] toActivate;
    public GameObject[] toDeactivate;
   public bool[] EventHappened;
   
   void Start(){

   }

   void Update()
    {


     for(int i = 0; i < EventHappened.Length; i++) {
if (EventHappened[i]){
    if (toActivate[i] != null){
 toActivate[i].SetActive(true);
    }
   if (toDeactivate[i] != null){toDeactivate[i].SetActive(false);}
     
}
     }
  

    }

}
