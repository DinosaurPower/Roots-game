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
        Debug.Log("Mouse Click Detected");
        if (dialogue != null){
            dialogue.FetchedString = Said_Text;

        }
    }
    
}
