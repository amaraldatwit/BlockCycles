using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Levels(){
        SceneManager.LoadScene("LevelSelect", LoadSceneMode.Single);
    }

    public void Help(){
        SceneManager.LoadScene("Help", LoadSceneMode.Single);
    }
    public void QuitGame(){
        Application.Quit();
    }
}
