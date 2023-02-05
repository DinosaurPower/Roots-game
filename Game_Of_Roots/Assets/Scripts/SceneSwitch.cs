using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitch : MonoBehaviour
{

    public Dialogue dialogue;
    public string NextSceneName;
private void Start(){

  dialogue = FindObjectOfType(typeof(Dialogue)) as Dialogue;

}
      private void OnMouseDown()
    {
       
        SceneManager.LoadScene(NextSceneName);

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
