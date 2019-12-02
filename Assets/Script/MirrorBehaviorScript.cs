using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorBehaviorScript : MonoBehaviour
{


    public float clickDelta = 0.35f;  // Max between two click to be considered a double click
 
     private bool click = false;
     private float clickTime;
    
    void OnMouseDrag(){
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
        transform.position = objPosition;
    }

    void OnMouseDown()
    {
        if (click && Time.time <= (clickTime + clickDelta)) {
             transform.Rotate(0,0,-90);
             click = false;
        }
                 else {
             click = true;
             clickTime = Time.time;
         }
        
    }

    
    void Update()
    {
        
    }         //Floating point variable to store the player's movement speed.

}

