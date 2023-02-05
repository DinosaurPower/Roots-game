using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneContoller : MonoBehaviour
{
    
   
   public bool[] EventHappened;
   public Activateable[] activateables;

   void Start(){
    var activateables = FindObjectsOfType<Activateable>();
   }
  void Update(){
      for(int i = 0; i < EventHappened.Length; i++){
        if (EventHappened[i]){
            for (int a = 0; a < activateables.Length; a++){
                if (activateables[a].EventNumber == i){
                    activateables[a].gameObject.SetActive(true);
                }
            }

        }
      }
  }
  
 }


