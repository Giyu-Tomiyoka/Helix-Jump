using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelmanager : MonoBehaviour
{
    public string mainlevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Quigame()
    {
        Application.Quit();
    }

    public void Maingame()
    {
        SceneManager.LoadScene(mainlevel);
    }
}
