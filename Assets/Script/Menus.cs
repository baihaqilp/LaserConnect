using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{   

    public bool gamePaused = false;
    public bool currentpage = true;
    public GameObject pauseMenu, settingMenu, lvlMenu, aboutMenu, menuLayout, backPress;

   public void OnMouseClick(){
       SceneManager.LoadScene(1);
    }

    public void OnLevelClick(){
        if (currentpage == true)
        {
            menuLayout.SetActive(false);
            lvlMenu.SetActive(true);
            backPress.SetActive(true);
        }else
        {
            menuLayout.SetActive(true);
            lvlMenu.SetActive(false);
        }
    }

    public void BackPressed(){
        menuLayout.SetActive(true);
        settingMenu.SetActive(false);
        lvlMenu.SetActive(false);
        aboutMenu.SetActive(false);
        backPress.SetActive(false);
    }
    public void SettingMenu(){
        if (currentpage == true)
        {
            menuLayout.SetActive(false);
            settingMenu.SetActive(true);
            backPress.SetActive(true);
        }else{
            menuLayout.SetActive(true);
            settingMenu.SetActive(false);
        }
    }
    public void About(){
        if (currentpage == true)
        {
            menuLayout.SetActive(false);
            aboutMenu.SetActive(true);
            backPress.SetActive(true);
        }else{
            menuLayout.SetActive(true);
            aboutMenu.SetActive(false);
        }
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
