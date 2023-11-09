using UnityEngine;

public class LaserBlink : MonoBehaviour
{
    public float blinkInterval = 0.5f; // Adjust this to control the blinking speed.
    private SpriteRenderer spriteRenderer;
    private bool isBlinking = true;

    private void Start()
    {
        spriteRenderer = GetComponent <SpriteRenderer>();
        InvokeRepeating("ToggleVisibility", 0f, blinkInterval);
    }

    private void ToggleVisibility()
    {
        isBlinking = !isBlinking;
        spriteRenderer.enabled = isBlinking;
    }
}
