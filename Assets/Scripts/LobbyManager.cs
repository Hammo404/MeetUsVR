using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LobbyManager : MonoBehaviour
{
    public TMP_InputField nameInput;

    //This method saves the player's entered name and loads the next scene.
    public void OnJoinRoomButton()
    {
        //Save the name entered in the input field to PlayerPrefs for persistence across scenes.
        PlayerPrefs.SetString("PlayerName", nameInput.text);

        //Load the main 'Room' scene.
        SceneManager.LoadScene("Room");
    }
}
