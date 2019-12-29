using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject light;
    public GameObject sW;
    public GameObject scoreBoard;

    private float    timer;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        scoring(timer);
    }

    public void scoring(float timer){
        if(timer >= 0f && timer <= 20f){
            score = 100;
        }else if(timer >= 21f && timer <= 45f){
            score = 75;
        }else if(timer >= 46f && timer <= 60f){
            score = 50;
        }else if(timer >= 61f && timer <= 90f){
            score = 25;
        }else{
            score = 0;
        }
    }

    private void OnGUI() {
      GUI.Label (new Rect(125,10,100,30),"score :  "+score);
      GUI.Label (new Rect(125,0,100,30),"Time :  "+(int)timer);  
    }
}
