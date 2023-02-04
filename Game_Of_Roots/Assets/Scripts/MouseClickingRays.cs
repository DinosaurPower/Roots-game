using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickingRays : MonoBehaviour
{
       public Ray ray;
    public Vector3 mousePosition;
    // Start is called before the first frame update
 private Camera camera;
    
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }


    // Update is called once per frame
    void Update()
    {
           DetectObjectWithRaycast();
    }

     public void DetectObjectWithRaycast()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
Debug.Log("Laser");
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log($"{hit.collider.name} Detected",
                    hit.collider.gameObject);
                    Debug.Log("Lasered");
            }
        }
    }
}
