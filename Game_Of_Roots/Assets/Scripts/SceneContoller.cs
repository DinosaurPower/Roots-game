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
    Refresh(); //if the very first thing in list is missing the list is being refreshed
}

      for(int i = 0; i < EventHappened.Length; i++){  
       
        if (EventHappened[i] != false){  //if some bools are triggered
                
                  //  Debug.Log(i+"activated");
                    activateables[i].gameObject.SetActive(true); //we activate specific objects in scene
                
            }

        }
      }

      public void Refresh(){

        activateables = new Activateable[0]; //we restart the list
         activateables =  FindObjectsOfTypeAll(typeof(Activateable)) as Activateable[]; //add every object with class activateable to the list
   
    //Debug.Log(activateables[0]);
    length = activateables.Length; //i forgot where i needed it but well let it stay

      }
  }
  
 


