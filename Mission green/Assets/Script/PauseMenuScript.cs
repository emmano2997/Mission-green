using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public static bool GameIspause = false;
    public GameObject PauseMenuUi;

    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (GameIspause){
                Resume();

            } else  {
                Pause();
            }
        }
    } 
    public void Resume(){
    PauseMenuUi.SetActive(false);
    Time.timeScale = 1f;
    GameIspause = false;
    }
    void Pause(){
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIspause = true;
    }
    
    public void LoadMenu(){
        Time.timeScale = 1f;
       SceneManager.LoadScene("MenuScene");
    }
    public void QuitGame(){
        Debug.Log("Quiting game");
        Application.Quit();
    }

}