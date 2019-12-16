using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    private LineRenderer lineRenderer;

    // public float maxRayDistance = 1.0e30f;
    public Transform LaserHit;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = false;
        lineRenderer.useWorldSpace= true;
    }

    // Update is called once per frame
    void Update()
    {
        // Laser();
        // Debug.DrawLine (transform.position, transform.position + Vector3.up * maxRayDistance);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
        Debug.DrawLine(transform.position, hit.point);
        
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, LaserHit.point);

        if(Input.GetKey(KeyCode.Space))
        {
            lineRenderer.enabled = false;
        } else {
            lineRenderer.enabled  = true;
        }
        if (hit.collider.tag == "Mirrors") {
            lineRenderer.SetPosition (2, hit.point + 100.0f * Vector2.Reflect (transform.position, hit.normal));
            
        }
    }


    
    // void Laser () {
    // Ray ray = new Ray (transform.position, Vector3.up);
    // RaycastHit hit;
    // lineRenderer.SetPosition (0, ray.origin);
    // if (Physics.Raycast (ray, out hit, 100)) {
    //     lineRenderer.SetPosition (1, hit.point);
    // } else {
    //     lineRenderer.SetPosition (1, ray.GetPoint (100));
    // }
    
}
