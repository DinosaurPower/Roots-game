using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue_Objects : MonoBehaviour
{
    public GameManager gameManager;
    public int EventNumber;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType(typeof(GameManager)) as GameManager; //find game magnager
    }

   public void Activate(){
    gameManager.eventsDone[EventNumber] = true; //activate certain event
   }
}
