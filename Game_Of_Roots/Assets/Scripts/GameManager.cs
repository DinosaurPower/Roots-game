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
                Debug.LogError("AAAAAAA");
            }
            return _instance;
        }
    }
    

    private void Awake(){
             DontDestroyOnLoad(gameObject);
        _instance = this;
        
    } 


    // Update is called once per frame
    void Update()
    {
        
        for(int i = 0; i < eventsDone.Length; i++) 
sceneControl.EventHappened[i] = eventsDone[i];
        }
       //sceneControl.EventHappened[0] = eventsDone[0];
    }

