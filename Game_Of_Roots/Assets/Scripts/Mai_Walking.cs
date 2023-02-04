using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mai_Walking : MonoBehaviour
{
    public Vector2 characterPos;
    private Vector2 mousePos;
    public Camera mainCamera;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //Vector3 mousePos = Input.mousePosition;
         if(Input.GetMouseButtonDown(0)){ //checking if the mouse is down
    characterPos = mainCamera.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y)); //this function adapts mouse position from the screen to in-game screen
gameObject.transform.position = Vector2.MoveTowards(transform.position, characterPos, speed*Time.deltaTime);
         }
         
    }


}
