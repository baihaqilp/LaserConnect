using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{   

    public bool gamePaused = false;
    public bool currentpage = true;
    public GameObject pauseMenu, settingMenu, lvlMenu, aboutMenu, menuLayout;

   public void OnMouseClick(){
       SceneManager.LoadScene(1);
    }

    public void OnLevelClick(){
        if (currentpage == true)
        {
            menuLayout.SetActive(false);
            lvlMenu.SetActive(true);
        }else
        {
            menuLayout.SetActive(true);
            lvlMenu.SetActive(false);
        }
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
        // PauseMenu();
    }

    public void UnpauseGame(){
        pauseMenu.SetActive(false);
        gamePaused = false;
        Time.timeScale = 1;
    }
}
