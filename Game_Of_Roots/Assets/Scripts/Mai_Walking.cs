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
    public Transform transform;
    public Character_Flip flip;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        transform = gameObject.GetComponent<Transform>();
       
         whereToGo = transform.position; //at first we fetch where the object is right now

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
             anim.SetBool("IsWalking", false);

}
      
     if (gameObject.transform.position.x != characterPos.x){
                anim.SetBool("IsWalking", true); } //preset for animation
        if (gameObject.transform.position.x >= characterPos.x){ //if the targeted location is on away, we flip character
          flip.FlipLeft();
        //Debug.Log("-1");
        } 
        
        if (gameObject.transform.position.x < characterPos.x){ //second part of character flip
          flip.FlipRight();
          //Debug.Log("1");
        }
    }
}

    //basically, the character is constantly moving toward the point, and the picked point is defined by mouse click



