using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static int score;
    public GameObject tryAgainPanel;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lastScoreText;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI tryPanelCoinText;

    public void SetTryAgainActive(bool isActive)
    {
        
        tryAgainPanel.SetActive(isActive);
    }

    void Start()
    {

        Time.timeScale = 1f;
        SetTryAgainActive(false);
        score = 0;
    }


    private void Update()
    {
        Application.targetFrameRate = 60;
        coinText.text = PlayerPrefs.GetInt("Coin").ToString();
        scoreText.text = "Score: " + score;
        lastScoreText.text = "Last Score: " + PlayerPrefs.GetInt("LastScore").ToString();
        highScoreText.text = "Personal Best: " + PlayerPrefs.GetInt("HighScore").ToString();
        tryPanelCoinText.text = PlayerPrefs.GetInt("Coin").ToString();
    }



}
