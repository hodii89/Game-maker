using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton: MonoBehaviour
{
    public void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void OnButtonPress()
{
    SceneManager.LoadScene("StartScreen");
   
}
}
