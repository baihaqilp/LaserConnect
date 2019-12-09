using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{   
   public void OnMouseClick(){
       SceneManager.LoadScene(1);
    }

    public void OnLevelClick(){
        SceneManager.LoadScene(2);
    }

    public void BackPressed(){
        SceneManager.LoadScene(0);
    }
}
