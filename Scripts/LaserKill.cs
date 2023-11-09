using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserKill : MonoBehaviour
{

    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bird"))
        {
            gameManager.SetTryAgainActive(true);
            Time.timeScale = 0;
            if(GameManager.score > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", GameManager.score);
            }
            PlayerPrefs.SetInt("LastScore", GameManager.score);

        }
    }
}
