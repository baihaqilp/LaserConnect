using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{   
    void OnMouseDown(){
        Debug.Log("jadi");
        SceneManager.LoadScene("Level1");
            
    }
}
