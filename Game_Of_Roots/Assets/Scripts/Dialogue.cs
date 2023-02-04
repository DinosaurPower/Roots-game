using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Dialogue : MonoBehaviour
{
    public string FetchedString; //here I am keeping and updating dialogue text
 public TMP_Text Dialogue_Text;


    // Update is called once per frame
    void Update()
    {
        if (Dialogue_Text != null){
            Dialogue_Text.text = FetchedString; //here the dialogue text updates
        }
    }
}
