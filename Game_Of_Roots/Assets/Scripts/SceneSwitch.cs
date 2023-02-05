using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitch : MonoBehaviour
{

    public Dialogue dialogue;
    public string NextSceneName;
private void Start(){

 

}
      private void OnMouseDown()
    {
       
        SceneManager.LoadScene(NextSceneName); //load scene you need

    }

    private void OnMouseOver(){
       // dialogue.
      // Debug.Log("IsPointed");
       dialogue.pointImage.SetActive(true); //we activating image that shows hthat stuff is activateablr

    }

    private void OnMouseExit(){
        dialogue.pointImage.SetActive(false); //when mouse is away from activateable stuff interaction image turns off
    }
}
