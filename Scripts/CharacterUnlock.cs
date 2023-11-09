using UnityEngine;
using UnityEngine.UI;

public class CharacterUnlock : MonoBehaviour
{
    public Button[] characterButtons;
    public int[] coinThresholds;  // The number of coins required to unlock each character
    public Image selectedCharacterImage; // Reference to the UI Image for displaying the selected character
    private int coins;
    private int selectedCharacterIndex = 0; // Set the default selected character to the 0th index

    public Sprite[] characterSprites; // Array of character sprites

    void Start()
    {
        coins = PlayerPrefs.GetInt("Coin", 0);
        UpdateCharacterButtons();
        UpdateSelectedCharacterImage();
    }

    void UpdateCharacterButtons()
    {
        for (int i = 0; i < characterButtons.Length; i++)
        {
            bool isUnlocked = coins >= coinThresholds[i];
            characterButtons[i].interactable = isUnlocked;

            // Add a click event for character buttons to select a character
            int characterIndex = i; // Capture the character index in a local variable
            characterButtons[i].onClick.AddListener(() => SelectCharacter(characterIndex));
        }
    }

    void SelectCharacter(int characterIndex)
    {
        if (characterIndex >= 0 && characterIndex < characterButtons.Length)
        {
            selectedCharacterIndex = characterIndex;
            UpdateSelectedCharacterImage();
        }
    }

    void UpdateSelectedCharacterImage()
    {
        if (selectedCharacterIndex >= 0 && selectedCharacterIndex < characterSprites.Length)
        {
            selectedCharacterImage.sprite = characterSprites[selectedCharacterIndex];
        }
        else
        {
            // Display a placeholder image or leave the image empty
            selectedCharacterImage.sprite = null;
        }
    }

}
