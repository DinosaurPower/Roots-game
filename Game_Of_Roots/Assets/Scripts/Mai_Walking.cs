using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mai_Walking : MonoBehaviour
{
    public Vector3 characterPos;
    private Vector3 mousePos;
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 mousePos = Input.mousePosition;
         Debug.log(mousePos);
    }


private void OnMouseClick(){
    characterPos = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 500.0f)); 
    Debug.Log("Clicked"+mousePos); 
}

}
