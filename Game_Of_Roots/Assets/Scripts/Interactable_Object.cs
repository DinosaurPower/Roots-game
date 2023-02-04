using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Interactable_Object : MonoBehaviour
{
    public string Said_Text = "";
public Dialogue dialogue;
private void Start(){

  dialogue = FindObjectOfType(typeof(Dialogue)) as Dialogue;

}
    // Start is called before the first frame update
      private void OnMouseDown()
    {
       
        if (dialogue != null){
 //Debug.Log("CLICKED");
            dialogue.FetchedString = Said_Text;

        }

        if (GetComponent<Clue_Objects>() != null){
          GetComponent<Clue_Objects>().Activate();
        }
    }

    private void OnMouseOver(){
       // dialogue.
      // Debug.Log("IsPointed");
       dialogue.pointImage.SetActive(true);

    }

    private void OnMouseExit(){
        dialogue.pointImage.SetActive(false);
    }
    
}
