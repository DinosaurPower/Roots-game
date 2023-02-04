using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mai_Walking : MonoBehaviour
{
    public Vector2 characterPos;
    private Vector2 mousePos;
    private Vector2 whereToGo;
    public Camera mainCamera;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
         characterPos = transform.position; //at first we fetch where the object is right now
    }

    // Update is called once per frame
    void Update()
    {
         //Vector3 mousePos = Input.mousePosition;
         if(Input.GetMouseButtonDown(0)){ //checking if the mouse is down
    characterPos = mainCamera.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, transform.position.y)); //this function adapts mouse position from the screen to in-game screen
whereToGo = new Vector2(characterPos.x, transform.position.y); //a crutch to keep character y and mouse input x
         }
         gameObject.transform.position = Vector2.MoveTowards(transform.position, whereToGo, speed*Time.deltaTime); //MoveTowards (from where, where to, speed) is a function tht drags objects somewhere
         
         if (gameObject.transform.position.x == characterPos.x){
            Debug.Log("We are here"); } else { Debug.Log("Walking");}

    }

    //basically, the character is constantly moving toward the point, and the picked point is defined by mouse click


}
