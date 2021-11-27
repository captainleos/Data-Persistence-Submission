using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainUI : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;

    private void Awake()
    {
        bestScoreText = transform.Find("BestScore Text").GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        bestScoreText.text = "Best Score : " + DataPersistence.Instance.bestPlayer + " : " + DataPersistence.Instance.highestScore;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}