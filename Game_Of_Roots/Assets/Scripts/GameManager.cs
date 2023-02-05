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
             DontDestroyOnLoad(gameObject); //keep the object that posesses this class when switch between scenes
        _instance = this; //it's and instance
        
    } 


    // Update is called once per frame
    void Update()
    {
        
        for(int i = 0; i < eventsDone.Length; i++)  //transfer bools from static to non-static so they will be interactable
sceneControl.EventHappened[i] = eventsDone[i];
        }
       //sceneControl.EventHappened[0] = eventsDone[0];
    }

