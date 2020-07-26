using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public void NewGame() {
        PlayerPrefs.SetInt("GamesPlayed", PlayerPrefs.GetInt("GamesPlayed", 0) + 1);
        Debug.Log("New Game Was Started, Games Played: " + PlayerPrefs.GetInt("GamesPlayed", 0).ToString());
    }
    public void QuitGame() {
        PlayerPrefs.Save();
        Application.Quit(0);
    }
}