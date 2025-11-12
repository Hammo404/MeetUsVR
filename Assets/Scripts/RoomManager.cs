using UnityEngine;
using TMPro;

public class RoomManager : MonoBehaviour
{
    public TMP_Text playerNameText;

    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        playerNameText.text = "Welcome, " + playerName + "!";
    }
}
