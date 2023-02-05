using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool[] eventsDone;
    public SceneContoller sceneControl;
    private static GameManager _instance;
    public static GameManager Instance{


        get{
            if (_instance == null){
                Debug.LogError("AAAAAAA"); //error return
            }
            return _instance;
        }
    }
    

    private void Awake(){
            if (_instance == null)

                //if not, set instance to this
                _instance = this;

            //If instance already exists and it's not this:
            else if (_instance != this)

                //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
                Destroy(gameObject);    

            //Sets this to not be destroyed when reloading scene
            DontDestroyOnLoad(gameObject);   


       
    
        
    } 




    // Update is called once per frame
    void Update()
    {
        
        for(int i = 0; i < eventsDone.Length; i++)  //transfer bools from static to non-static so they will be interactable
sceneControl.EventHappened[i] = eventsDone[i];
        }
       //sceneControl.EventHappened[0] = eventsDone[0];
    }

