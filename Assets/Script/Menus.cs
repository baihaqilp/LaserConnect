using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{   
   public void OnMouseClick(){
        Application.LoadLevel(1);
    }

    public void OnLevelClick(){
        Application.LoadLevel(2);
    }

    public void OnGameClick(){
        Application.LoadLevel(3);
    }
    public void BackPressed(){
        Application.LoadLevel(0);
    }
    public void FeedbackUser(){
        Application.LoadLevel(5);
    }
}
