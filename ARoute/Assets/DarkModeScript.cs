using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DarkModeScript : MonoBehaviour
{
    public Image background; // Assign the background UI image
    public TextMeshProUGUI[] texts; // Assign all text elements
    public Button darkModeButton; // Assign the button
    public Button[] buttonsToChange; // Dedicated dark mode button
    public Color darkModeButtonColor; // Set dark mode colour for buttons
    //public Color darkBackgroundForButtons; // Set dark mode colour for background of buttons
    public Image buttonsBox; // Set dark mode colour for buttons box

    void Start()
    {
        // Attach the event listener only to Dark Mode button
        darkModeButton.onClick.AddListener(EnableDarkMode);
    }

    public void EnableDarkMode()
    {
        Debug.Log("Dark Mode Button Clicked!"); // Check if button is being triggered

        // Change UI to Dark Mode
        background.color = Color.black; // Dark background
        buttonsBox.color = Color.grey; // White buttons box
        foreach (TextMeshProUGUI txt in texts)
        {
            txt.color = Color.white; // Dark text
        }

        // Change colour of all specified buttons
        foreach (Button btn in buttonsToChange)
        {
            Debug.Log("Changing colour of: " + btn.gameObject.name); // Check which buttons are changing colours, if any

            btn.GetComponent<Image>().color = darkModeButtonColor; // Changes colour of buttons to the chosen colour
        }

        // Save dark mode preference
        PlayerPrefs.SetInt("DarkMode", 1);
        PlayerPrefs.Save();
    }
}
