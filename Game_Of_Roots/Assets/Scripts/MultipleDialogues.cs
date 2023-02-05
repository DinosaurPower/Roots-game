using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleDialogues : MonoBehaviour
{
    public string[] allPhrases;
    public int turn;
    public Interactable_Object interactable;
    // Start is called before the first frame update
    void Start()
    { turn = 0;
        interactable = GetComponent<Interactable_Object>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextPhrase(){
        interactable.Said_Text = allPhrases[turn];
        turn++;
        if (turn > allPhrases.Length){
            turn = 0;
        }
    }
}
