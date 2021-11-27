using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUI : MonoBehaviour
{
    public string input;
    public TextMeshProUGUI currentPlayerText;
    public TextMeshProUGUI highscoreText;


    private void Awake()
    {
        currentPlayerText = transform.Find("Current Player Text").GetComponent<TextMeshProUGUI>();
        highscoreText = transform.Find("Highscore Text").GetComponent<TextMeshProUGUI>();
    }
    void Start()
    {
        DataPersistence.Instance.currentPlayer = "Noone";
        highscoreText.text = "Highscore " + DataPersistence.Instance.highestScore + " by " + DataPersistence.Instance.bestPlayer;
    }

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);

        DataPersistence.Instance.currentPlayer = input;
        currentPlayerText.text = "Current player is " + DataPersistence.Instance.currentPlayer;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        DataPersistence.Instance.SaveScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
