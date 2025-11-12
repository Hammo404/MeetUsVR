using UnityEngine;
using TMPro;

public class RoomManager : MonoBehaviour
{
    public TMP_Text playerNameText;

    void Start()
    {
        // Uses "Player" as a default if no name was set (e.g., if scene loaded directly).
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");

        //Update the UI text component to display a welcome message with the retrieved name.
        playerNameText.text = "Welcome, " + playerName + "!";
    }
}
