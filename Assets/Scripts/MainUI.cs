using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    void Start()
    {
        // Set highest score textField
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
