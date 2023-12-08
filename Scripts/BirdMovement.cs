using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BirdMovement : MonoBehaviour
{

    public float jumpForce = 5.0f;
    private Rigidbody2D rb;
    private Bird bird;
    private bool isBirdDead = false;

    public SpriteRenderer characterSprite;

    public Sprite[] sprites;

    private AudioSource audioSource;
    public bool IsBirdDead // controlled from other script
    {
        get { return isBirdDead; }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bird = GetComponent<Bird>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!isBirdDead && Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            audioSource.Play();
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") + 1);
            GameManager.score++;
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    public void ChangeBirdSprite(int spriteIndex)
    {
        if (characterSprite != null && sprites != null && spriteIndex >= 0 && spriteIndex < sprites.Length)
        {
            characterSprite.sprite = sprites[spriteIndex];
        }
    }
}
