using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LobbyManager : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void OnJoinRoomButton()
    {
        PlayerPrefs.SetString("PlayerName", nameInput.text);
        SceneManager.LoadScene("Room");
    }
}
