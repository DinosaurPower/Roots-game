using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Flip : MonoBehaviour
{
public float Sc;
    void Start(){
         Sc = transform.localScale.x;
    }
    public void FlipRight(){
        gameObject.GetComponent<Transform>().localScale = new Vector3(Sc, transform.localScale.y, 0);
    }
    public void FlipLeft(){
        gameObject.GetComponent<Transform>().localScale = new Vector3(-Sc, transform.localScale.y, 0);
    }
}
