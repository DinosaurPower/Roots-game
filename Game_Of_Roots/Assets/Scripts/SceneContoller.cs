using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneContoller : MonoBehaviour
{
    
   
   public bool[] EventHappened;
public Activateable[] activateables;
private int length;

   void Start(){
    Refresh();
   }
  void Update(){
if (activateables[0] == null){
    Refresh();
}

      for(int i = 0; i < EventHappened.Length; i++){
       
        if (EventHappened[i] != false){
                
                    Debug.Log(i+"activated");
                    activateables[i].gameObject.SetActive(true);
                
            }

        }
      }

      public void Refresh(){

        activateables = new Activateable[0];
         activateables =  FindObjectsOfTypeAll(typeof(Activateable)) as Activateable[];
   
    Debug.Log(activateables[0]);
    length = activateables.Length;

      }
  }
  
 


