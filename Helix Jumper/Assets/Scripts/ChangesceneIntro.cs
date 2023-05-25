using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangesceneIntro : MonoBehaviour
{
    public int scene;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangeScene", 7f);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }
}
