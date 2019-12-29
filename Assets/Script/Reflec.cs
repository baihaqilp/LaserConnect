using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]

public class Reflec : MonoBehaviour
{

    public int reflection;
    public float maxLenght;

    private LineRenderer lineRenderer;
    private Ray ray;
    private RaycastHit hit;
    private Vector3 direction;
    public GameObject feedback, mirror, light;
    public bool gamePaused = false;

    // Start is called before the first frame update
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        createLight();
    }

    void createLight(){
        ray = new Ray(transform.position, transform.forward);
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
        float remainingLenght = maxLenght;

        for (int i = 0; i < reflection; i++)
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hit, remainingLenght))
            {
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, hit.point);
                remainingLenght -= Vector3.Distance(ray.origin, hit.point);
                ray = new Ray(hit.point, Vector3.Reflect(ray.direction, hit.normal));
                if (hit.collider.tag == "switch"){
                    Time.timeScale = 0;
                    feedback.SetActive(true);
                    light.SetActive(false);
                    mirror.SetActive(false);
                }else if(hit.collider.tag != "Mirror"){
                    break;
                }

            }else{
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, ray.origin + ray.direction * remainingLenght);
            }
        }
    }
}
