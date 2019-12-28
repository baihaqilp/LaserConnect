using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{   

    public bool gamePaused = false;
    public GameObject pauseMenu;

   public void OnMouseClick(){
       SceneManager.LoadScene(1);
    }

    public void OnLevelClick(){
        SceneManager.LoadScene(2);
    }

    public void BackPressed(){
        SceneManager.LoadScene(0);
    }
    public void SettingMenu(){
        SceneManager.LoadScene(4);
    }
    public void About(){
        
    }
    public void PauseMenu(){
        if (gamePaused == false)
        {
            Time.timeScale = 0;
            gamePaused = true;
            pauseMenu.SetActive(true);
        }else
        {
            pauseMenu.SetActive(false);
            gamePaused = false;
            Time.timeScale = 1;
        }
    }

    void Update(){
        
    }

    public void UnpauseGame(){
        pauseMenu.SetActive(false);
        gamePaused = false;
        Time.timeScale = 1;
    }
}
