using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitch : MonoBehaviour
{
      private void OnMouseDown()
    {
       
        if (dialogue != null){
 
            dialogue.FetchedString = Said_Text;

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
