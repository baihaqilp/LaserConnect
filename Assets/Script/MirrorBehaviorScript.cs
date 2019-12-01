using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorBehaviorScript : MonoBehaviour
{
    
    void OnMouseDrag(){
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
        transform.position = objPosition;
    }
    
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log(Input.touchCount);
        }
    }         //Floating point variable to store the player's movement speed.

}

