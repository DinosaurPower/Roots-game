using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool[] isActivated;
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
