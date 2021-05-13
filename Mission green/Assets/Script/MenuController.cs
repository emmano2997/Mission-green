using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void CallScene(string sceneName)//chamador de cena
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Quit()//sair 
    {
        Application.Quit();
    }
}
