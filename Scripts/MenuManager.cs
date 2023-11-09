using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MenuManager : MonoBehaviour
{

    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI coinText;
    public GameObject aboutPanel;
    public GameObject charactersPanel;

    public BirdMovement birdMovement;

    void Start()
    {
        Time.timeScale = 1f;
        highScoreText.text = "Personal Best: " + PlayerPrefs.GetInt("HighScore").ToString();
    }

    private void Update()
    {
        coinText.text = PlayerPrefs.GetInt("Coin").ToString();
    }

    public void SetAboutPanelActive()
    {
        aboutPanel.SetActive(true);
    }

    public void CloseAboutPanel()
    {
        aboutPanel.SetActive(false);
    }

    public void SetCharactersPanelActive()
    {
        charactersPanel.SetActive(true);
    }

    public void CloseCharactersPanel()
    {
        charactersPanel.SetActive(false);
    }

    public void SetCharacter(int index)
    {
        birdMovement.ChangeBirdSprite(index);
    }

}
