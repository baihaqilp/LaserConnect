using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recordScript : MonoBehaviour
{

    public GameObject Panel;
    public int score;
    public Text resultScore;

    public void hideRecord(){
        if (score > 10)
        {
            Panel.gameObject.SetActive(true);
        }else{
            Panel.gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hideRecord();
        resultScore.text = " "+ score;
    }
}
