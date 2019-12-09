using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorBehaviorScript : MonoBehaviour
{

    public GameObject[] waypoints;
    int current = 0;
    float radius = 1;

    public float clickDelta = 0.35f, speed;  // Max between two click to be considered a double click
 
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
        if (Vector2.Distance(waypoints[current].transform.position, transform.position)<radius)
        {
            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }

}

