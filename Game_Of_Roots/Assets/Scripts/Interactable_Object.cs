using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Interactable_Object : MonoBehaviour
{
    public string Said_Text = "";
public Dialogue dialogue;
private void Start(){

  dialogue = FindObjectOfType(typeof(Dialogue)) as Dialogue; //find dialogue script

}
    // Start is called before the first frame update
      private void OnMouseDown()
    {
       
        if (dialogue != null){
 //Debug.Log("CLICKED");
            dialogue.FetchedString = Said_Text; //change dialogue string into object description

        }
        
if (GetComponent<MultipleDialogues>()!= null){
    GetComponent<MultipleDialogues>().nextPhrase();
}
        if (GetComponent<Clue_Objects>() != null){
          GetComponent<Clue_Objects>().Activate(); //if object is activateable, activate it
        }
    }

    private void OnMouseOver(){
       // dialogue.
      // Debug.Log("IsPointed");
       dialogue.pointImage.SetActive(true); //when you draw mouse on object it shows that it's activateable

    }

    private void OnMouseExit(){
        dialogue.pointImage.SetActive(false); //when you put away mouse image disappears
    }
    
}
